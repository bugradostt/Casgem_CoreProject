using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.BusinessLayer.Concrete;
using PizzaPan.DataAccessLayer.EntityFramework;
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

        CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        public IActionResult Index()
        {
            var values = _categoryService.TGetList();
            return View(values);
        }
    }
}
