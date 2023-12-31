﻿using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.BusinessLayer.ValidationRules.OurTeamValidator;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class OurTeamController : Controller
    {
        readonly IOurTeamService _ourTeamService;
        public OurTeamController(IOurTeamService ourTeamService)
        {
            _ourTeamService = ourTeamService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddOurTeam()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOurTeam(OurTeam p)
        {
            CreateOurTeamValidator createOurTeamValidator = new CreateOurTeamValidator();
            ValidationResult result = createOurTeamValidator.Validate(p);
            if (result.IsValid)
            {

                _ourTeamService.TInsert(p);
                return RedirectToAction("ListOurTeam");
            }
            else
            {
                foreach (var i in result.Errors)
                {
                    ModelState.AddModelError(i.PropertyName, i.ErrorMessage);
                }

            }
            return View();
        }

        public PartialViewResult ListOurTeam()
        {
            var values = _ourTeamService.TGetList();
            return PartialView(values);
        }

        public IActionResult DeleteOurTeam(int id)
        {
            var foundId = _ourTeamService.TGetById(id);
            _ourTeamService.TDelete(foundId);
            return RedirectToAction("ListOurTeam");
        }


        [HttpGet]
        public IActionResult EditOurTeam(int id)
        {
            var foundId = _ourTeamService.TGetById(id);
            return View(foundId);
        }

        [HttpPost]
        public IActionResult EditOurTeam(OurTeam p)
        {
            _ourTeamService.TUpdate(p);
            return RedirectToAction("ListOurTeam");
           
        }

    }
}
