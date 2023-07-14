using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            var values = _contactService.TGetList().OrderByDescending(x => x.ContactId).ToList();
            return View(values);
        }

        public IActionResult DeleteProduct(int id)
        {
            var foundId = _contactService.TGetById(id);
            _contactService.TDelete(foundId);
            return RedirectToAction("Index");
        }

        public IActionResult GetMessageBtThanks(int id)
        {
            var values = _contactService.TGetContactBySubjectWithtThanks();
            return View(values);
        }
    }
}
