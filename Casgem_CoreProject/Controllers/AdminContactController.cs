using Microsoft.AspNetCore.Mvc;
using PizzaPan.DataAccessLayer.Concrete;
using PizzaPan.EntityLayer.Concrete;
using System.Linq;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class AdminContactController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
           
            var values = c.ContactInfos.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult EditContact(int id)
        {
            var foundId = c.ContactInfos.Find(id);
            return View(foundId);
        }

        [HttpPost]
        public IActionResult EditContact(ContactInfo p)
        {
            c.ContactInfos.Update(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
