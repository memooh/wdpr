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
    public class ModeratorController : Controller
    {
        private readonly KliniekContext _context;

        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public ModeratorController(KliniekContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> overzichtBehandelaars()
        {
            var currentuser = await _userManager.GetUserAsync(HttpContext.User);
            var behandelaars = await _context.Gebruikers.Where(g => g.Clienten != null).ToListAsync();

            if (await _roleManager.RoleExistsAsync("Moderator"))
            {
                if (await _userManager.IsInRoleAsync(currentuser, "Moderator"))
                {
                    return View(behandelaars);
                }
            }
            return RedirectToAction("Home", "Index");
        }
    }
}