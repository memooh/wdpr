using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models;

namespace wdpr.Controllers
{
    public class AanmeldingController : Controller
    {
        private readonly KliniekContext _context;

        public AanmeldingController(KliniekContext context)
        {
            _context = context;
        }

        // GET: Aanmelding
        public async Task<IActionResult> Index()
        {
            return View(await _context.Aanmeldingen.ToListAsync());
        }

        // GET: Aanmelding/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aanmelding = await _context.Aanmeldingen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aanmelding == null)
            {
                return NotFound();
            }

            return View(aanmelding);
        }

        // GET: Aanmelding/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aanmelding/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Gebruikersnaam,Voornaam,Achternaam,Geboortedatum,Behandelaar")] Aanmelding aanmelding)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aanmelding);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aanmelding);
        }

        // GET: Aanmelding/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aanmelding = await _context.Aanmeldingen.FindAsync(id);
            if (aanmelding == null)
            {
                return NotFound();
            }
            return View(aanmelding);
        }

        // POST: Aanmelding/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Gebruikersnaam,Voornaam,Achternaam,Geboortedatum,Behandelaar")] Aanmelding aanmelding)
        {
            if (id != aanmelding.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aanmelding);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AanmeldingExists(aanmelding.Id))
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
            return View(aanmelding);
        }

        // GET: Aanmelding/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aanmelding = await _context.Aanmeldingen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aanmelding == null)
            {
                return NotFound();
            }

            return View(aanmelding);
        }

        // POST: Aanmelding/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aanmelding = await _context.Aanmeldingen.FindAsync(id);
            _context.Aanmeldingen.Remove(aanmelding);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AanmeldingExists(int id)
        {
            return _context.Aanmeldingen.Any(e => e.Id == id);
        }

        public IActionResult LeeftijdVragen()
        {
            return View();
        }

        [Authorize(Roles="Ouder")]
        public IActionResult CreateOuder(){
            return View();
            
        }

        public IActionResult Aanmelden() {
            return View(new AanmeldingModel());
        }

        [HttpPost]
        public async Task<IActionResult> Aanmelden(AanmeldingModel aanmeldingModel) {

            Aanmelding aanmelding = new Aanmelding {
                Voornaam = aanmeldingModel.Voornaam,
                Achternaam = aanmeldingModel.Achternaam,
                Datum = aanmeldingModel.Datum,
                Voogd = await _context.Gebruikers.SingleAsync(g => g.Email == aanmeldingModel.VoogdEmail),
                Behandelaar = await _context.Gebruikers.SingleAsync(g => g.Id == aanmeldingModel.BehandelaarEmail),
                GeboorteDatum = aanmeldingModel.GeboorteDatum,
                HeeftAccount = false
            };

            _context.Aanmeldingen.Add(aanmelding);
            _context.SaveChanges();
            
            return View();
        }
    }
}
