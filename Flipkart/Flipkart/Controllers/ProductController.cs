using Flipkart.Service;
using Flipkart.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flipkart.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult IndexProduct()
        {
            var pro = _productService.GetAll();
            return View(pro);
        }
        public IActionResult Delete(int id)
        {
            var pro = _productService.GetById(id);
            return View(pro);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            _productService.Delete(id);
            return RedirectToAction("IndexProduct");

        }

        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult InsertProduct(Product pro)
        {
            if (ModelState.IsValid)
            {
                _productService.Insert(pro);
                return RedirectToAction("IndexProduct");
            }
            //return View(pro);
            return Json(pro);
        }
      
    
        public IActionResult Update()
        {
            return View();
        }
    }
}
