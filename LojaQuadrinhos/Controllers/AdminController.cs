using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LojaQuadrinhos.Contexts;
using LojaQuadrinhos.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LojaQuadrinhos.Controllers
{
    
    public class AdminController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ShopContext _context;
        public AdminController(ShopContext context, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public string CheckLogin()
        {
            return "Logged: " + User.Identity.Name + " - " + User.Identity.IsAuthenticated;
        }

        [Authorize("Bearer")]
        public ActionResult Control()
        {
            return View();
        }
    }
}
