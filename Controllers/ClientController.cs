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

namespace wdpr.Controllers
{
    [Authorize(Roles = "Voogd")]
    public class ClientController : Controller
    {
        private readonly KliniekContext _context;
        private readonly UserManager<Gebruiker> _userManager;

        public ClientController(KliniekContext context, UserManager<Gebruiker> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Client
        public async Task<IActionResult> Index()
        {
            Gebruiker HuidigeGebruiker = await _userManager.GetUserAsync(HttpContext.User);
            return View(await _context.Gebruikers.Where(g => g.Voogd == HuidigeGebruiker).ToListAsync());
        }

        // GET: Client/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gebruiker HuidigeGebruiker = await _userManager.GetUserAsync(HttpContext.User);
            var gebruiker = await _context.Gebruikers
                                  .Include(g => g.Deelnames)
                                  .ThenInclude(d => d.Chat)
                                  .ThenInclude(c => c.Berichten)
                                  .ThenInclude(b => b.Deelname)
                                  .ThenInclude(d => d.Client)
                                  .AsSplitQuery()
                                  .FirstOrDefaultAsync(m => m.Id == id);
            
        
            if (gebruiker == null)
            {
                return NotFound();
            }


            GebruikerChatViewModel gebruikerChatViewModel = new GebruikerChatViewModel(gebruiker);
            return View(gebruikerChatViewModel);
        }

        // GET: Client/Create
        // public IActionResult Create()
        // {
        //     return View();
        // }

        // POST: Client/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Create([Bind("Geboortedatum,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] Gebruiker gebruiker)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _context.Add(gebruiker);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View(gebruiker);
        // }

        // GET: Client/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gebruiker HuidigeGebruiker = await _userManager.GetUserAsync(HttpContext.User);
            var gebruiker = await _context.Gebruikers.Where(m => m.Voogd == HuidigeGebruiker).FirstAsync(m => m.Id == id);
            
            if (gebruiker == null)
            {
                return NotFound();
            }
            return View(gebruiker);
        }

        // POST: Client/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Geboortedatum,Id,UserName,Email,PhoneNumber")] Gebruiker gebruiker)
        {
            if (id != gebruiker.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Gebruiker HuidigeGebruiker = await _userManager.GetUserAsync(HttpContext.User);
                    var gebruikerEdit = await _context.Gebruikers.Where(m => m.Voogd == HuidigeGebruiker).FirstOrDefaultAsync(m => m.Id == id);

                    gebruikerEdit.Geboortedatum = gebruiker.Geboortedatum;
                    gebruikerEdit.UserName = gebruiker.UserName;
                    gebruikerEdit.Email = gebruiker.Email;
                    gebruikerEdit.PhoneNumber = gebruiker.PhoneNumber;

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

        // GET: Client/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gebruiker HuidigeGebruiker = await _userManager.GetUserAsync(HttpContext.User);
            var gebruiker = await _context.Gebruikers.Where(m => m.Voogd == HuidigeGebruiker).FirstOrDefaultAsync(m => m.Id == id);

            if (gebruiker == null)
            {
                return NotFound();
            }

            return View(gebruiker);
        }

        // POST: Client/Delete/5
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
