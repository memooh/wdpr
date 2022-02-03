using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Input;

namespace wdpr.Controllers
{
    [Authorize(Roles = "Voogd")]
    public class VoogdController : Controller
    {
        private readonly KliniekContext _context;
        private readonly UserManager<Gebruiker> _userManager;

        public VoogdController(KliniekContext context, UserManager<Gebruiker> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Voogd
        public async Task<IActionResult> Index()
        {
            Gebruiker HuidigeGebruiker = await _userManager.GetUserAsync(HttpContext.User);

            var kliniekContext = _context.Gebruikers.Include(g => g.Voogd).Where(g => g.VoogdId == HuidigeGebruiker.Id);
            return View(await kliniekContext.ToListAsync());
        }

        // GET: Voogd/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gebruiker HuidigeGebruiker = await _userManager.GetUserAsync(HttpContext.User);

            var gebruiker = await _context.Gebruikers
                .Include(g => g.Voogd)
                .FirstOrDefaultAsync(m => m.Id == id && m.VoogdId == HuidigeGebruiker.Id);
            if (gebruiker == null)
            {
                return NotFound();
            }

            return View(gebruiker);
        }

        // GET: Voogd/Create
        public IActionResult Create()
        {
            return View(new RegistratieModel());
        }

        // POST: Voogd/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RegistratieModel registratieModel)
    {
        if (ModelState.IsValid)
        {
            Gebruiker HuidigeGebruiker = await _userManager.GetUserAsync(HttpContext.User);
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
                VoogdId = HuidigeGebruiker.Id,
                IsActief = registratieModel.IsActief
            };

            var result = await _userManager.CreateAsync(user, registratieModel.Wachtwoord);

            if (result.Succeeded)
            {
                await _context.SaveChangesAsync();
                await _userManager.AddToRoleAsync(user, "Client");

                return RedirectToAction(nameof(Index));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        return View(new RegistreerAlsClient());
    }

        // GET: Voogd/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gebruiker HuidigeGebruiker = await _userManager.GetUserAsync(HttpContext.User);

            var gebruiker = await _context.Gebruikers.SingleAsync(m => m.Id == id && m.VoogdId == HuidigeGebruiker.Id);

            if (gebruiker == null)
            {
                return NotFound();
            }
            return View(gebruiker);
        }

        // POST: Voogd/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Geboortedatum,Voornaam,Achternaam,Adres,Postcode,Woonplaats,IsActief,Id,Email")] Gebruiker gebruiker)
        {
            Gebruiker HuidigeGebruiker = await _userManager.GetUserAsync(HttpContext.User);

            if (id != gebruiker.Id || gebruiker.VoogdId == HuidigeGebruiker.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var gebruikerEdit = await _context.Gebruikers.FirstOrDefaultAsync(m => m.Id == id);
                    gebruikerEdit.Geboortedatum = gebruiker.Geboortedatum;
                    gebruikerEdit.Voornaam = gebruiker.Voornaam;
                    gebruikerEdit.Achternaam = gebruiker.Achternaam;
                    gebruikerEdit.Adres = gebruiker.Adres;
                    gebruikerEdit.Postcode = gebruiker.Postcode;
                    gebruikerEdit.Woonplaats = gebruiker.Woonplaats;
                    gebruikerEdit.IsActief = gebruiker.IsActief;
                    gebruikerEdit.Email = gebruiker.Email;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GebruikerExists(gebruiker.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(gebruiker);
        }

        // GET: Voogd/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gebruiker HuidigeGebruiker = await _userManager.GetUserAsync(HttpContext.User);

            var gebruiker = await _context.Gebruikers
                .Include(g => g.Voogd)
                .FirstOrDefaultAsync(m => m.Id == id && m.VoogdId == HuidigeGebruiker.Id);
            if (gebruiker == null)
            {
                return NotFound();
            }

            return View(gebruiker);
        }

        // POST: Voogd/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var gebruiker = await _context.Gebruikers.FindAsync(id);
            _context.Gebruikers.Remove(gebruiker);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GebruikerExists(string id)
        {
            return _context.Gebruikers.Any(e => e.Id == id);
        }
    }
}
