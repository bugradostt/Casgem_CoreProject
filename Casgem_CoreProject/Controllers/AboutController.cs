using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class AboutController : Controller
    {
        IAboutService _aboutService;
        public AboutController(IAboutService aboutService)
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
