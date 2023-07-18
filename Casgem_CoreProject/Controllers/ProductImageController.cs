using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;
using PizzaPan.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class ProductImageController : Controller
    {
        readonly IProductImageService _productImageService;
        public ProductImageController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ImageFileViewModel p)
        {
            var resource = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(p.Image.FileName);
            var imageName = Guid.NewGuid() + extension;
            var saveLocation = resource + "/wwwroot/images/" + imageName;
            var stream = new FileStream(saveLocation, FileMode.Create);
            p.Image.CopyTo(stream);
            ProductImage productImage = new ProductImage();
            productImage.ProductImageUrl = imageName;
            _productImageService.TInsert(productImage);
            return RedirectToAction("ImageList");
        }
    }
}
