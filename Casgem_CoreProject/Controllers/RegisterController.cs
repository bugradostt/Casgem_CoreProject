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
    public class RegisterController : Controller
    {
        readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel p)
        {
            //if(ModelState.IsValid)
            //{
            //    AppUser appUser = new AppUser()
            //    {
            //        Name = p.Name,
            //        Surname = p.Surname,
            //        Email = p.Mail,
            //        UserName = p.UserName
            //    };
            //    await _userManager.CreateAsync(appUser, p.Password);
            //    return RedirectToAction("Index", "Login");
            //}
            //else
            //{
            //    return View();
            //}

            AppUser appUser = new AppUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                Email = p.Mail,
                UserName = p.UserName
            };
            if (p.Password==p.ConfirmPassword )
            {

                var result= await _userManager.CreateAsync(appUser, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var i in result.Errors)
                    {
                        ModelState.AddModelError("", i.Description);
                    }
                }

            }
            else
            {
                ModelState.AddModelError("", "Şifreler Eşleşmiyor");
            }

            return View();

        }
    }
}
