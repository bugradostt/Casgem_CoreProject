using MailKit;
using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.DataAccessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class AdminAboutController : Controller
    {
        readonly IAboutService _aboutService;

        public AdminAboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var values = _aboutService.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            var fountId = _aboutService.TGetById(id);
            return View(fountId);
        }

        [HttpPost]
        public IActionResult EditAbout(About p)
        {
            _aboutService.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
