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
    public class ZelfhulpgroepController : Controller
    {
        private readonly KliniekContext _context;

        public ZelfhulpgroepController(KliniekContext context)
        {
            _context = context;
        }

        // GET: Zelfhulpgroep
        public async Task<IActionResult> Index()
        {
            return View(await _context.Zelfhulpgroepen.ToListAsync());
        }

        // GET: Zelfhulpgroep/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zelfhulpgroep = await _context.Zelfhulpgroepen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zelfhulpgroep == null)
            {
                return NotFound();
            }

            return View(zelfhulpgroep);
        }

        // GET: Zelfhulpgroep/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zelfhulpgroep/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Hulpverlener")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam,Description")] Zelfhulpgroep zelfhulpgroep)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zelfhulpgroep);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zelfhulpgroep);
        }

        // GET: Zelfhulpgroep/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zelfhulpgroep = await _context.Zelfhulpgroepen.FindAsync(id);
            if (zelfhulpgroep == null)
            {
                return NotFound();
            }
            return View(zelfhulpgroep);
        }

        // POST: Zelfhulpgroep/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Hulpverlener")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,Description")] Zelfhulpgroep zelfhulpgroep)
        {
            if (id != zelfhulpgroep.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zelfhulpgroep);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZelfhulpgroepExists(zelfhulpgroep.Id))
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
            return View(zelfhulpgroep);
        }

        // GET: Zelfhulpgroep/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zelfhulpgroep = await _context.Zelfhulpgroepen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zelfhulpgroep == null)
            {
                return NotFound();
            }

            return View(zelfhulpgroep);
        }

        // POST: Zelfhulpgroep/Delete/5
        [Authorize(Roles = "Hulpverlener")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zelfhulpgroep = await _context.Zelfhulpgroepen.FindAsync(id);
            _context.Zelfhulpgroepen.Remove(zelfhulpgroep);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZelfhulpgroepExists(int id)
        {
            return _context.Zelfhulpgroepen.Any(e => e.Id == id);
        }
    }
}
