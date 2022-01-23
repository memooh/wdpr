using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace wdpr.Controllers
{
    // [Authorize(Roles = "Moderator")]
    public class ModeratorController : Controller
    {
        private readonly KliniekContext _context;
        private readonly UserManager<Gebruiker> _userManager;

        public ModeratorController(KliniekContext context, UserManager<Gebruiker> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index() {
            return View(await _context.Chats.Include(c => c.Deelnames).ToListAsync());
        }

        public async Task<IActionResult> Behandelingen() {
            List<Gebruiker> gebruikers = await _context.Gebruikers.Include(g => g.Behandelingen).ThenInclude(g => g.Behandeling).ToListAsync();
            List<Gebruiker> behandelaars = new List<Gebruiker>();

            foreach (var item in gebruikers)
            {   
               foreach (var rol in await _userManager.GetRolesAsync(item))
               {
                    if(rol == "Behandelaar")
                        behandelaars.Add(item);
               }
            }

            return View(behandelaars);
        }

        public async Task<IActionResult> Inzien(int Id) {
            return View(await _context.Chats
                                            .Include(c => c.Behandelaar)
                                            .Include(c => c.Deelnames)
                                            .ThenInclude(d => d.Berichten)
                                            .Include(c => c.Deelnames)
                                            .ThenInclude(d => d.Client)
                                            .AsSplitQuery()
                                            .SingleAsync(c => c.Id == Id)
            );
        }

        public async Task<IActionResult> Aanmeldingen () {
            Gebruiker IngelogdeGebruiker = await _userManager.GetUserAsync(HttpContext.User);
            return View(await _context.Aanmeldingen.Where(a => a.Behandelaar == IngelogdeGebruiker).ToListAsync());
        }

        public async Task<IActionResult> AanmeldingBekijken(int AanmeldingsId) {
            return View(await _context.Aanmeldingen.SingleAsync(a => a.Id == AanmeldingsId));
        }

        [HttpGet]
        public async Task<IActionResult> GenereerAccount(BlokkeerModel blokkeerModel)
        {
            Aanmelding aanmelding = _context.Aanmeldingen.Single(a => a.Id == blokkeerModel.Id);
            
            Gebruiker gebruiker = new Gebruiker
            {
                UserName = aanmelding.Gebruikersnaam,
                Email = aanmelding.Gebruikersnaam,
            };

            aanmelding.HeeftAccount = true;

            await _userManager.CreateAsync(gebruiker, aanmelding.GenereerWachtwoord());

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task Blokkeer([FromBody] BlokkeerModel blokkeerModel) {
            Deelname deelname = await _context.Deelnames.SingleAsync(d => d.Id == blokkeerModel.Id);
            deelname.Geblokkeerd = deelname.Geblokkeerd ? false : true;
            await _context.SaveChangesAsync(); 
        }
        
    }
}