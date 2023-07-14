using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.DataAccessLayer.Concrete;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class DiscountController : Controller
    {
        readonly IDiscountService _discountServide;

        public DiscountController(IDiscountService discountService)
        {
            _discountServide = discountService;
        }


        
        [HttpGet]
        public IActionResult CreateCode()
        {
            string[] symbols = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L" ,"M"};
            int c1, c2, c3, c4;
            Random random = new Random();
            c1 = random.Next(0, symbols.Length);
            c2 = random.Next(0, symbols.Length);
            c3 = random.Next(0, symbols.Length);
            c4 = random.Next(0, symbols.Length);
            int c5 = random.Next(10, 100);
            ViewBag.code = symbols[c1] + symbols[c2] + symbols[c3] + symbols[c4] + c5;
            return View();

        
        
        }

        [HttpPost]
        public IActionResult CreateCode(Discount p)
        {
            p.DiscountCreateDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.DiscountEndDate = Convert.ToDateTime(DateTime.Now.AddDays(3));
            _discountServide.TInsert(p);
            return RedirectToAction("ListCode");

        }


        public IActionResult ListCode()
        {
            var values = _discountServide.TGetList();
            return View(values);
        }


        //Context c = new Context();
        //public IActionResult Index(Discount p )
        //{
        //    Random sayi = new Random();
        //    int randomSayi = sayi.Next(1000, 10000);


        //    Random harf = new Random();
        //    string harfler = "abcdefghijklmnopqrstuvwxyz";
        //    char harf1 = harfler[harf.Next(harfler.Length)];
        //    char harf2 = harfler[harf.Next(harfler.Length)];

        //    string code = randomSayi.ToString() + harf1+harf2;

        //    p.DiscountCode = code;
        //    p.DiscountCount = 5;
        //   // p.DiscountCreateDate= DateTime.Now.ToShortDateString();
           
           
         


        //    c.Discounts.Add(p);
        //    c.SaveChanges();

        //    return View();



        //}
    }
}
