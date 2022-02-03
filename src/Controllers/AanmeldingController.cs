using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models;

public class AanmeldingController : Controller {
    private readonly ILogger<AanmeldingController> _logger;
    private readonly KliniekContext _context;
    private readonly UserManager<Gebruiker> _userManager;
    private readonly SignInManager<Gebruiker> _signInManager;
    public AanmeldingController(ILogger<AanmeldingController> logger, KliniekContext kliniekContext, UserManager<Gebruiker> userManager, SignInManager<Gebruiker> signInManager)
    {
        _logger = logger;
        _context = kliniekContext;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<IActionResult> Index(int? BehandelingId, string? BehandelaarId, string? VoogdijId)
    {    
        return View("BehandelingenOverzicht", _context.Behandelingen.Include(b => b.Behandelaren).ThenInclude(b => b.Behandelaar).ToList());
    }

    public IActionResult Behandeling(int BehandelingId)
    {
        var Behandelingen = _context.Behandelingen.Include(b => b.Behandelaren).ThenInclude(b => b.Behandelaar);
        Console.WriteLine(_userManager.GetUserId(HttpContext.User));
        if (HttpContext.User != null && HttpContext.User.Identity.IsAuthenticated)
        {
            var CurrentUserId = _userManager.GetUserId(HttpContext.User);
            if (_context.Aanmeldingen.Any(a => a.Client.Id == CurrentUserId && a.Behandeling.Id == BehandelingId))
            {
                return RedirectToAction(nameof(Success), new { titel = "Je bent al aangemeld voor deze behandeling!", beschrijving = "Klik terug om naar het overzicht te gaan" });
            }
        }

        if (Behandelingen.Any(b => b.Id == BehandelingId))
        {
            return View("BehandelaarOverzicht", Behandelingen.Single(b => b.Id == BehandelingId));
        }

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Behandelaar(int BehandelingId, string BehandelaarId)
    {
        var Behandelingen = _context.Behandelingen.Include(b => b.Behandelaren).ThenInclude(b => b.Behandelaar);

        if (Behandelingen.Any(b => b.Id == BehandelingId) && _context.Gebruikers.Any(b => b.Id == BehandelaarId))
        {
            var Gebruikers = _context.Gebruikers.Include(g => g.Voogdij);
            var CurrentUserId = _userManager.GetUserId(HttpContext.User);

            var BehandelingIdRedirect = _context.Behandelingen.Single(b => b.Id == BehandelingId).Id;

            ViewData["BehandelaarId"] = BehandelaarId;
            ViewData["BehandelingId"] = BehandelingId;

            if (Gebruikers.Any(g => g.Id == CurrentUserId))
            {
                List<Gebruiker> LegeLijst = new List<Gebruiker>();
                if (LegeLijst != null)
                {
                    foreach (var item in Gebruikers.Where(g => g.VoogdId == CurrentUserId).ToList())
                    {
                        if (!_context.Aanmeldingen.Any(a => a.Client.Id == item.Id && a.Behandeling.Id == BehandelingId))
                        {
                            LegeLijst.Add(item);
                        }
                    }
                }

                return View("AanmeldenSelectie", new AanmeldenAlsClient(BehandelingIdRedirect, LegeLijst, _context.Aanmeldingen.Any(a => a.Client.Id == CurrentUserId && a.Behandeling.Id == BehandelingId)));
            }

            return View("AanmeldenSelectie", new AanmeldenAlsClient(BehandelingIdRedirect, null, true));

        }

        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Behandelaar(AanmeldenAlsClient aanmeldModel)
    {
        if (ModelState.IsValid)
        {
            if (!_context.Gebruikers.Any(g => g.Email == aanmeldModel.Email) && !_context.Aanmeldingen.Any(g => g.Email == aanmeldModel.Email))
            {
                Aanmelding aanmelding = new Aanmelding
                {
                    Email = aanmeldModel.Email,
                    Voornaam = aanmeldModel.Voornaam,
                    Achternaam = aanmeldModel.Achternaam,
                    GeboorteDatum = aanmeldModel.Geboortedatum,
                    Adres = aanmeldModel.Adres,
                    Postcode = aanmeldModel.Postcode,
                    Woonplaats = aanmeldModel.Woonplaats,
                    Behandeling = _context.Behandelingen.Single(b => b.Id == aanmeldModel.BehandelingId),
                    Behandelaar = _context.Gebruikers.Single(b => b.Id == aanmeldModel.BehandelaarId),
                    Datum = DateTime.Today,
                };
                
                _context.Aanmeldingen.Add(aanmelding);
                _context.SaveChanges();
                return View("~/Views/Shared/ResultPage.cshtml", new ResultPageModel("Aanmelding voltooid", "Aanmelding successvol voltooid"));
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Email is al in gebruik");

                var Gebruikers = _context.Gebruikers.Include(g => g.Voogdij);
                var CurrentUserId = _userManager.GetUserId(HttpContext.User);

                if (Gebruikers.Any(g => g.Id == CurrentUserId))
                {
                    return View("AanmeldenSelectie", new AanmeldenAlsClient(aanmeldModel.BehandelingId, Gebruikers.Where(g => g.VoogdId == CurrentUserId).ToList(), true));
                }
                
                return View("AanmeldenSelectie", new AanmeldenAlsClient(aanmeldModel.BehandelingId, null, true));
            }
        }

        return RedirectToAction(nameof(Index));
    }
    public async Task<IActionResult> SelecteerClient(int BehandelingId, string BehandelaarId, string VoogdijId)
    {
        var Behandelingen = _context.Behandelingen.Include(b => b.Behandelaren).ThenInclude(b => b.Behandelaar);

        if (await _context.Gebruikers.AnyAsync(g => g.Id == VoogdijId) && await Behandelingen.AnyAsync(b => b.Id == BehandelingId) && await _context.Gebruikers.AnyAsync(g => g.Id == BehandelaarId))
        {
            var VoogdijGebruiker =  await _context.Gebruikers.SingleAsync(g => g.Id == VoogdijId);

            Aanmelding aanmelding = new Aanmelding
            {
                Email = VoogdijGebruiker.Email,
                Voornaam = VoogdijGebruiker.Voornaam,
                Achternaam = VoogdijGebruiker.Achternaam,
                GeboorteDatum = VoogdijGebruiker.Geboortedatum,
                Adres = VoogdijGebruiker.Adres,
                Postcode = VoogdijGebruiker.Postcode,
                Woonplaats = VoogdijGebruiker.Woonplaats,
                Behandeling = await  Behandelingen.SingleAsync(b => b.Id == BehandelingId),
                Behandelaar =  await _context.Gebruikers.SingleAsync(g => g.Id == BehandelaarId),
                Datum = DateTime.Today,
                Client = VoogdijGebruiker,
                HeeftAccount = true
            };

            await GenereerChats(VoogdijGebruiker, _context.Gebruikers.Single(g => g.Id == BehandelaarId));
            
            _context.Aanmeldingen.Add(aanmelding);
            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Success));
        } 
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Success(string titel = "Aanmelding voltooid", string beschrijving = "Aanmelding successvol voltooid")
    {
        return View("~/Views/Shared/ResultPage.cshtml", new ResultPageModel(titel, beschrijving));
    }

        public async Task GenereerChats(Gebruiker HuidigeGebruiker, Gebruiker GekozenGebruiker)
        {
            Chat NieuweChat = new Chat
            {
                Naam = "Chat met " + HuidigeGebruiker.Email,
                Actief = true,
                Behandelaar = GekozenGebruiker,
                Zelfhulpgroep = null
            };

            _context.Chats.Add(NieuweChat);

            _context.Deelnames.Add(new Deelname
            {
                Chat = NieuweChat,
                Client = HuidigeGebruiker,
                Geblokkeerd = false,
                Toetredingsdatum = new DateTime()
            });

            _context.Deelnames.Add(new Deelname
            {
                Chat = NieuweChat,
                Client = GekozenGebruiker,
                Geblokkeerd = false,
                Toetredingsdatum = new DateTime()
            });
        }
}