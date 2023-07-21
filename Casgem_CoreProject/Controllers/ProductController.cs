using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        readonly ICategoryService  _categoryService;
        public ProductController(IProdcutService prodcutService, ICategoryService categoryService)
        {
            _prodcutService = prodcutService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var values = _prodcutService.TGetProductsWithCategory().OrderByDescending(x => x.ProductId).ToList();
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
            var values = _categoryService.TGetList();
            ViewBag.categoryList = new SelectList(values,"CategoryId","CategoryName");
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
