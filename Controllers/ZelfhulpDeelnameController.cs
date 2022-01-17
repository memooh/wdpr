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
    public class ZelfhulpDeelnameController : Controller
    {
        private readonly KliniekContext _context;

        public ZelfhulpDeelnameController(KliniekContext context)
        {
            _context = context;
        }

        // GET: ZelfhulpDeelname
        public async Task<IActionResult> Index()
        {
            return View(await _context.ZelfhulpDeelnames.ToListAsync());
        }

        // GET: ZelfhulpDeelname/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zelfhulpDeelname = await _context.ZelfhulpDeelnames
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zelfhulpDeelname == null)
            {
                return NotFound();
            }

            return View(zelfhulpDeelname);
        }

        // GET: ZelfhulpDeelname/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ZelfhulpDeelname/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Toetredingsdatum,Zelfhulpgroep,Client")] ZelfhulpDeelname zelfhulpDeelname)
        {
                if (ModelState.IsValid)
                {
                    _context.Add(zelfhulpDeelname);

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
        
            return View(zelfhulpDeelname);
        }

        // GET: ZelfhulpDeelname/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zelfhulpDeelname = await _context.ZelfhulpDeelnames.FindAsync(id);
            if (zelfhulpDeelname == null)
            {
                return NotFound();
            }
            return View(zelfhulpDeelname);
        }

        // POST: ZelfhulpDeelname/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Toetredingsdatum")] ZelfhulpDeelname zelfhulpDeelname)
        {
            if (id != zelfhulpDeelname.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zelfhulpDeelname);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZelfhulpDeelnameExists(zelfhulpDeelname.Id))
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
            return View(zelfhulpDeelname);
        }

        // GET: ZelfhulpDeelname/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zelfhulpDeelname = await _context.ZelfhulpDeelnames
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zelfhulpDeelname == null)
            {
                return NotFound();
            }

            return View(zelfhulpDeelname);
        }

        // POST: ZelfhulpDeelname/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zelfhulpDeelname = await _context.ZelfhulpDeelnames.FindAsync(id);
            _context.ZelfhulpDeelnames.Remove(zelfhulpDeelname);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZelfhulpDeelnameExists(int id)
        {
            return _context.ZelfhulpDeelnames.Any(e => e.Id == id);
        }

    }
}
