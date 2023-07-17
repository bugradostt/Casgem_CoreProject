using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PizzaPan.EntityLayer.Concrete;
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


        public IActionResult Index()
        {
            return View();
        }
    }
}
