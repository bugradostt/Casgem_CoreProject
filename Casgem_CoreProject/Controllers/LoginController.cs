using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PizzaPan.EntityLayer.Concrete;
using PizzaPan.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        readonly SignInManager<AppUser> _singInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _singInManager = signInManager;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel p)
        {
            var result = await _singInManager.PasswordSignInAsync(p.UserName, p.Password, true, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
    }
}
