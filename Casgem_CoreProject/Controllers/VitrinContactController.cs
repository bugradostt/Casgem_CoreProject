using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class VitrinContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }
    }
}
