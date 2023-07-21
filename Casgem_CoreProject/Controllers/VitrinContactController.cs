using Microsoft.AspNetCore.Mvc;
using PizzaPan.DataAccessLayer.Concrete;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Linq;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class VitrinContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Context context = new Context();
            ViewBag.ContactInfoPhone = context.ContactInfos.Where(x=>x.ContactInfoId==1).Select(x=>x.ContactInfoPhone).FirstOrDefault();
            ViewBag.ContactInfoMail = context.ContactInfos.Where(x=>x.ContactInfoId==1).Select(x=>x.ContactInfoMail).FirstOrDefault();
            ViewBag.ContactInfoAdress = context.ContactInfos.Where(x=>x.ContactInfoId==1).Select(x=>x.ContactInfoAdress).FirstOrDefault();
            ViewBag.ContactInfoMaps = context.ContactInfos.Where(x=>x.ContactInfoId==1).Select(x=>x.ContactInfoMaps).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.ContactSendDateMessage = Convert.ToDateTime(DateTime.Now);
            Context context = new Context();
            context.Contacts.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
