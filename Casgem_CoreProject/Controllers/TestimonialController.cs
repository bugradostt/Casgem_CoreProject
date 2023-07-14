using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class TestimonialController : Controller
    {

        ITestimonialService _testimonialService;
        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }
        public IActionResult Index()
        {
            var values = _testimonialService.TGetList().OrderByDescending(x => x.TestimonialId).ToList();
            return View(values);
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var foundId = _testimonialService.TGetById(id);
            _testimonialService.TDelete(foundId);
            return RedirectToAction("Index");
        }
    }
}
