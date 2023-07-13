using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class ProductController : Controller
    {

        readonly IProdcutService _prodcutService;
        public ProductController(IProdcutService prodcutService)
        {
            _prodcutService = prodcutService;
        }
        public IActionResult Index()
        {
            var values = _prodcutService.TGetList().OrderByDescending(x => x.ProductId).ToList();
            return View(values);
        }

        public IActionResult DeleteProduct(int id)
        {
            var foundId = _prodcutService.TGetById(id);
            _prodcutService.TDelete(foundId);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p )
        {
            _prodcutService.TInsert(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            var foundId = _prodcutService.TGetById(id);

            return View(foundId);
        }

        [HttpPost]
        public IActionResult EditProduct(Product p)
        {
            _prodcutService.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
