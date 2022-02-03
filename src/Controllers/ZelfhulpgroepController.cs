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
using PagedList.Mvc;

namespace wdpr.Controllers
{
    public class ZelfhulpgroepController : Controller
    {
        private readonly KliniekContext _context;
        private readonly UserManager<Gebruiker> _userManager;

        public ZelfhulpgroepController(KliniekContext context, UserManager<Gebruiker> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Zelfhulpgroep
        public async Task<IActionResult> Index(string titel, string leeftijd)
        {
            var zelfhulpgroepen = _context.Zelfhulpgroepen.Include(z => z.ZelfhulpDeelnames).ThenInclude(z => z.Client).AsNoTracking();

            ViewBag.Titel = titel;
            ViewBag.Leeftijd = leeftijd;

            if (!String.IsNullOrEmpty(titel) || !String.IsNullOrEmpty(leeftijd))
            {
                zelfhulpgroepen = zelfhulpgroepen.Where(s => s.Naam.Contains(titel) || s.avgLeeftijd.Contains(leeftijd));
            }

            return View(await zelfhulpgroepen.ToListAsync());
        }

        // GET: Zelfhulpgroep/Details/5
        [Authorize(Roles = "Behandelaar")]
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

        public async Task<IActionResult> AanmeldenVoorGroep(int Id) {

            var CurrentUser = await _userManager.GetUserAsync(HttpContext.User);
            if(!_context.ZelfhulpDeelnames.Any(z => z.Zelfhulpgroep.Id == Id && z.Client == (Gebruiker) CurrentUser)) {
                _context.ZelfhulpDeelnames.Add(new ZelfhulpDeelname {
                    Zelfhulpgroep = await _context.Zelfhulpgroepen.SingleAsync(z => z.Id == Id),
                    Client = CurrentUser,
                    Toetredingsdatum = new DateTime()
                });

                
                _context.Deelnames.Add(new Deelname {
                    Geblokkeerd = false,
                    Chat = _context.Chats.Single(c => c.ZelfhulpgroepInt == Id),
                    Client = CurrentUser,
                    Toetredingsdatum = new DateTime()
                });
                
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Zelfhulpgroep/Create
        [Authorize(Roles = "Behandelaar")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zelfhulpgroep/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Behandelaar")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam,Description,avgLeeftijd")] Zelfhulpgroep zelfhulpgroep)
        {
            if (ModelState.IsValid)
            {
                var CurrentUser = await _userManager.GetUserAsync(HttpContext.User);

                _context.Add(zelfhulpgroep);
                await _context.SaveChangesAsync();
                Chat chat = new Chat {
                    Naam = zelfhulpgroep.Naam,
                    ZelfhulpgroepInt = zelfhulpgroep.Id,
                    Actief = true
                };

                _context.Chats.Add(chat);

                _context.Deelnames.Add(new Deelname {
                    Geblokkeerd = false,
                    Chat = chat,
                    Client = CurrentUser,
                    Toetredingsdatum = new DateTime()
                });

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zelfhulpgroep);
        }

        // GET: Zelfhulpgroep/Edit/5
        [Authorize(Roles = "Behandelaar")]
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
        [Authorize(Roles = "Behandelaar")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,Description,avgLeeftijd")] Zelfhulpgroep zelfhulpgroep)
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
        [Authorize(Roles = "Behandelaar")]
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
        [Authorize(Roles = "Behandelaar")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zelfhulpgroep = await _context.Zelfhulpgroepen.Include(d => d.ZelfhulpDeelnames).SingleAsync(z => z.Id == id);
            var deelnames = await _context.Deelnames
                                  .Include(d => d.Chat)
                                  .ThenInclude(c => c.Zelfhulpgroep)
                                  .Include(d => d.Chat)
                                  .ThenInclude(c => c.Deelnames)
                                  .ThenInclude(c => c.Berichten)
                                  .Where(d => d.Chat.ZelfhulpgroepInt == id)
                                  .ToListAsync();

            foreach (var item in deelnames)
            {
                foreach (var bericht in item.Berichten)
                {
                    _context.Berichten.Remove(bericht);
                }
                _context.Deelnames.Remove(item);
            }

            foreach (var item in zelfhulpgroep.ZelfhulpDeelnames)
            {
                _context.ZelfhulpDeelnames.Remove(item);
            }

            _context.Chats.Remove(zelfhulpgroep.Chat);

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
