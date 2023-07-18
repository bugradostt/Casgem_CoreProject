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
    public class ConfirmEmailController : Controller
    {

        readonly UserManager<AppUser> _userManager;
        public ConfirmEmailController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.username = TempData["UserName"];
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ConfirmMailViewModel p)
        {
            var user = await _userManager.FindByNameAsync(p.UserName);
            if (user.ConfirmCode.ToString()==p.ConfirmCode)
            {
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Login");

            }
            return View();
        }
    }
}
