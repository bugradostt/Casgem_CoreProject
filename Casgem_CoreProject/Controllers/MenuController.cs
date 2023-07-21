using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaPan.DataAccessLayer.Concrete;
using System.Linq;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class MenuController : Controller
    {
        Context c =new Context();
        public IActionResult Index()
        {
            var values = c.Categories.Include(x => x.Products).ToList();
            return View(values);
        }
    }
}
