using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models;
using Models.Input;

[Route("Authenticatie")]
public class AuthenticatieController : Controller 
{
    private readonly ILogger<AuthenticatieController> _logger;
    private readonly KliniekContext _context;
    private readonly UserManager<Gebruiker> _userManager;
    private readonly SignInManager<Gebruiker> _signInManager;
    private readonly IWebHostEnvironment _webHostEnvironment;
    public AuthenticatieController(ILogger<AuthenticatieController> logger, 
                                   KliniekContext kliniekContext, 
                                   UserManager<Gebruiker> userManager, 
                                   SignInManager<Gebruiker> signInManager,
                                   IWebHostEnvironment webHostEnvironment
                                   )
    {
        _logger = logger;
        _context = kliniekContext;
        _userManager = userManager;
        _signInManager = signInManager;
        _webHostEnvironment = webHostEnvironment;
    }

    [Route("Registratie/Client")]
    public IActionResult Client() {
        return View(new RegistreerAlsClient());
    }

    [Route("Registratie/Client")]
    [HttpPost]
    public async Task<IActionResult> Client(RegistreerAlsClient registratieModel)
    {
        if (ModelState.IsValid)
        {
            var user = new Gebruiker
            {
                UserName = registratieModel.Email,
                Email = registratieModel.Email,
                Voornaam = registratieModel.Voornaam,
                Achternaam = registratieModel.Achternaam,
                Geboortedatum = registratieModel.Geboortedatum,
                Adres = registratieModel.Adres,
                Postcode = registratieModel.Postcode,
                Woonplaats = registratieModel.Woonplaats,
                IsActief = registratieModel.IsVoogd
            };

            if (!registratieModel.IsVoogd && user.IsMinderjarig())
            {
                if (!(await _context.Gebruikers.AnyAsync(g => g.Email == registratieModel.VoogdEmail)))
                {
                    ModelState.AddModelError(string.Empty, "Voogd email bestaat niet");
                    return View(new RegistreerAlsClient());
                }
                else
                {
                    user.VoogdId = (await _context.Gebruikers.SingleAsync(g => g.Email == registratieModel.VoogdEmail)).Id;
                }
            }

            var result = await _userManager.CreateAsync(user, registratieModel.Wachtwoord);

            if (result.Succeeded)
            {
                await _context.SaveChangesAsync();
                await _userManager.AddToRoleAsync(user, registratieModel.IsVoogd ? "Voogd" : "Client");
                if (registratieModel.IsVoogd || !user.IsMinderjarig())
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                }

                return RedirectToAction(nameof(Success), new {
                    titel = "Succesvol aangemeld", 
                    beschrijving = "Uw account is met success aangemaakt! " + 
                    (!registratieModel.IsVoogd ? "Om toegang te krijgen tot de applicatie, moet je ouder/voogd toestemming geven via het beheer!" : "")
                    });
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        return View(new RegistreerAlsClient());
    }

    [Route("Registratie/Behandelaar")]
    public IActionResult Behandelaar()
    {
        return View(new RegistreerAlsBehandelaar(_context.Behandelingen));
    }

    [Route("Registratie/Behandelaar")]
    [HttpPost]
    public async Task<IActionResult> Behandelaar(RegistreerAlsBehandelaar registreerAlsBehandelaar)
    {
        if (ModelState.IsValid)
        {
            var afbeelding = new FileHandler(_webHostEnvironment).UploadFile(registreerAlsBehandelaar);
            var user = new Gebruiker
            {
                UserName = registreerAlsBehandelaar.Email,
                Email = registreerAlsBehandelaar.Email,
                Voornaam = registreerAlsBehandelaar.Voornaam,
                Achternaam = registreerAlsBehandelaar.Achternaam,
                Geboortedatum = registreerAlsBehandelaar.Geboortedatum,
                Adres = registreerAlsBehandelaar.Adres,
                Postcode = registreerAlsBehandelaar.Postcode,
                Woonplaats = registreerAlsBehandelaar.Woonplaats,
                Beschrijving = registreerAlsBehandelaar.Beschrijving,
                IsActief = true,
                Afbeelding = afbeelding
            };

            var result = await _userManager.CreateAsync(user, registreerAlsBehandelaar.Wachtwoord);

            if (result.Succeeded)
            {
                foreach (int GeselecteerdeId in registreerAlsBehandelaar.GeselecteerdeBehandelingen)
                {
                    _context.BehandelendeGebruikers.Add(new Behandeld
                    {
                        Behandelaar = user,
                        Behandeling = await _context.Behandelingen.SingleAsync(b => b.Id == GeselecteerdeId)
                    });
                }

                await _userManager.AddToRoleAsync(user, "Behandelaar");
                await _context.SaveChangesAsync();
                await _signInManager.SignInAsync(user, isPersistent: false);

                return RedirectToAction(nameof(Success));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        return View(new RegistreerAlsBehandelaar(_context.Behandelingen));
    }

    [Route("Login")]
    public IActionResult Login() {
        return View();
    }

    [Route("Login")]
    [HttpPost]
    public async Task<IActionResult> Login(LoginModel loginModel)
    {
        if (ModelState.IsValid)
        {
            if (await _context.Gebruikers.AnyAsync(g => g.Email == loginModel.Email))
            {
                var found = await _context.Gebruikers.SingleAsync(g => g.Email == loginModel.Email);
                if (found.IsActief)
                {
                    var result = await _signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Wachtwoord, loginModel.RememberMe, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        _logger.LogInformation("User logged in.");
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Onjuiste gegevens");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Je hebt nog geen toestemming van je ouder/voogd om in te loggen");
                }
            } 
            else 
            {
                ModelState.AddModelError(string.Empty, "Onjuiste gegevens");
            }
        }
        return View(loginModel);
    }

    [Route("Registratie/Success")]
    public IActionResult Success(string titel = "Succesvol aangemeld", string beschrijving = "Uw account is met success aangemaakt!")
    {
        return View("~/Views/Shared/ResultPage.cshtml", new ResultPageModel(titel, beschrijving));
    }
}