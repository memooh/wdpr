using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models;

namespace wdpr.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly KliniekContext _context;
        private readonly UserManager<Gebruiker> _userManager;
        public HomeController(ILogger<HomeController> logger, KliniekContext kliniekContext, UserManager<Gebruiker> userManager)
        {
            _logger = logger;
            _context = kliniekContext;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [Authorize(Roles = "Client, Behandelaar")]
        public async Task<IActionResult> ChatTest(string Begeleider = null, bool Nieuw = false, string hulpGroep = null)
        {
            Gebruiker HuidigeGebruiker = await _userManager.GetUserAsync(HttpContext.User);

            if(Nieuw && Begeleider != null) {
                Gebruiker GekozenGebruiker = await _context.Gebruikers.SingleAsync(g => g.Id == Begeleider);
                Chat NieuweChat = new Chat {
                    Naam = "Chat met " + HuidigeGebruiker.Email,
                    Actief = true, 
                    Behandelaar = GekozenGebruiker, 
                    Zelfhulpgroep = hulpGroep == null ? null : _context.Zelfhulpgroepen.Single(z => z.Id == int.Parse(hulpGroep))
                };
                
                _context.Chats.Add(NieuweChat);
                
                _context.Deelnames.Add(new Deelname {
                                        Chat = NieuweChat, 
                                        Client = await _userManager.GetUserAsync(HttpContext.User), 
                                        Geblokkeerd = false, 
                                        Toetredingsdatum = new DateTime()
                                    });

                _context.Deelnames.Add(new Deelname {
                                        Chat = NieuweChat, 
                                        Client = GekozenGebruiker, 
                                        Geblokkeerd = false, 
                                        Toetredingsdatum = new DateTime()
                                    });

                _context.SaveChanges();

                return RedirectToAction(nameof(ChatTest));
            }
            List<Deelname> Chats = await _context.Deelnames
                                                .Include(d => d.Chat)
                                                .ThenInclude(c => c.Behandelaar)
                                                .Include(d => d.Client)
                                                .Where(d => d.Client == HuidigeGebruiker)
                                                .Where(d => d.Chat.Actief)
                                                .ToListAsync();
        
            return View(new ChatViewModel(Chats, _userManager, HuidigeGebruiker));
        }
        
        public async Task<IActionResult> LeeftijdVragenAanmelden(){
            return View();
        }

        public async Task<IActionResult> Diensten(){
            return View();
        }

        public async Task<IActionResult> OverOns(int AanmeldingsId){
            return View();
        }
    }
}
