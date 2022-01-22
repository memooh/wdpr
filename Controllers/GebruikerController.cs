using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models;

namespace wdpr.Controllers
{
    public class GebruikerController : Controller
    {
        private readonly KliniekContext _context;

        public GebruikerController(KliniekContext context)
        {
            _context = context;
        }

        // GET: Gebruiker
        public async Task<IActionResult> Index()
        {
            var kliniekContext = _context.Gebruikers.Include(g => g.Behandelaar);
            return View(await kliniekContext.ToListAsync());
        }

        // GET: Gebruiker/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gebruiker = await _context.Gebruikers
                .Include(g => g.Behandelaar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gebruiker == null)
            {
                return NotFound();
            }

            return View(gebruiker);
        }

        // GET: Gebruiker/Create
        public IActionResult Create()
        {
            ViewData["BehandelaarId"] = new SelectList(_context.Gebruikers, "Id", "Id");
            return View();
        }

        // POST: Gebruiker/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Geboortedatum,BehandelaarId,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] Gebruiker gebruiker)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gebruiker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BehandelaarId"] = new SelectList(_context.Gebruikers, "Id", "Id", gebruiker.BehandelaarId);
            return View(gebruiker);
        }

        // GET: Gebruiker/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gebruiker = await _context.Gebruikers.FindAsync(id);
            if (gebruiker == null)
            {
                return NotFound();
            }
            ViewData["BehandelaarId"] = new SelectList(_context.Gebruikers, "Id", "Id", gebruiker.BehandelaarId);
            return View(gebruiker);
        }

        // POST: Gebruiker/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Geboortedatum,BehandelaarId,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] Gebruiker gebruiker)
        {
            if (id != gebruiker.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gebruiker);
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
            ViewData["BehandelaarId"] = new SelectList(_context.Gebruikers, "Id", "Id", gebruiker.BehandelaarId);
            return View(gebruiker);
        }

        // GET: Gebruiker/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gebruiker = await _context.Gebruikers
                .Include(g => g.Behandelaar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gebruiker == null)
            {
                return NotFound();
            }

            return View(gebruiker);
        }

        // POST: Gebruiker/Delete/5
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
