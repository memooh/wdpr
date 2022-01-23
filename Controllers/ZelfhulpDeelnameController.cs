using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Models;

namespace wdpr.Controllers
{
    public class ZelfhulpDeelnameController : Controller
    {
        private readonly KliniekContext _context;

        private UserManager<IdentityUser> _userManager;

        public ZelfhulpDeelnameController(KliniekContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ZelfhulpDeelname
        public async Task<IActionResult> Index()
        {
            var kliniekContext = _context.ZelfhulpDeelnames.Include(z => z.Zelfhulpgroep);
            return View(await kliniekContext.ToListAsync());
        }

        // GET: ZelfhulpDeelname/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zelfhulpDeelname = await _context.ZelfhulpDeelnames
                .Include(z => z.Zelfhulpgroep)
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
            ViewData["ZelfhulpgroepId"] = new SelectList(_context.Zelfhulpgroepen, "Id", "Naam");
            return View();
        }

        // POST: ZelfhulpDeelname/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Toetredingsdatum,ZelfhulpgroepId")] ZelfhulpDeelname zelfhulpDeelname)
        {
            // Thnx daddy Nokinsu <3
            var cu = await _userManager.GetUserAsync(HttpContext.User);
            // var zpp = await _context.Zelfhulpgroepen.Where(x => x.Deelname == null).ToListAsync();
            if (ModelState.IsValid)
            {
                zelfhulpDeelname.Client = cu;
                _context.Add(zelfhulpDeelname);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ZelfhulpgroepId"] = new SelectList(_context.Zelfhulpgroepen, "Id", "Id", zelfhulpDeelname.ZelfhulpgroepId);
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
            ViewData["ZelfhulpgroepId"] = new SelectList(_context.Zelfhulpgroepen, "Id", "Id", zelfhulpDeelname.ZelfhulpgroepId);
            return View(zelfhulpDeelname);
        }

        // POST: ZelfhulpDeelname/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Toetredingsdatum,ZelfhulpgroepId")] ZelfhulpDeelname zelfhulpDeelname)
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
            ViewData["ZelfhulpgroepId"] = new SelectList(_context.Zelfhulpgroepen, "Id", "Id", zelfhulpDeelname.ZelfhulpgroepId);
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
                .Include(z => z.Zelfhulpgroep)
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
