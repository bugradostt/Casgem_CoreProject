using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.DataAccessLayer.Abstract;

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
    }
}
