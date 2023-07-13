using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.BusinessLayer.Concrete;
using PizzaPan.DataAccessLayer.EntityFramework;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        //CategoryManager cm = new CategoryManager(new EfCategoryDal());
        readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _categoryService.TGetList().OrderByDescending(x=>x.CategoryId).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            _categoryService.TInsert(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id)
        {
            var foundId = _categoryService.TGetById(id);
            _categoryService.TDelete(foundId);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var foundId = _categoryService.TGetById(id);
            return View(foundId);
        }

        [HttpPost]
        public IActionResult EditCategory(Category p)
        {
            _categoryService.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
