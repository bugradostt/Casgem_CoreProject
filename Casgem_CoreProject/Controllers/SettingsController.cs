﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PizzaPan.EntityLayer.Concrete;
using PizzaPan.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class SettingsController : Controller
    {
        readonly UserManager<AppUser> _userManager;
        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = value.Name;
            model.Surname = value.Surname;
            model.Email = value.Email;
            model.City = value.City;
            model.UserName = value.UserName;
            return View(model);
        }
    }
}
