using Microsoft.AspNetCore.Mvc;
using OnlineStore_HW.Models;
using OnlineStore_HW.Models.Utils;
using OnlineStore_HW.Services;

namespace OnlineStore_HW.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            ViewBag.Breadcrumb = new List<BreadcrumbItem>()
            {
                new BreadcrumbItem("Products", "Products", "Index")
            };

            List<Product> products = _productService.GetProducts();
            return View(products);
        }

        public IActionResult ProductById([FromRoute]int? id)
        {
            if (id is null) return RedirectToAction("Index");
            Product? product = _productService.GetProductById((int)id);
            if (product is null) return RedirectToAction("Index");

            ViewBag.Breadcrumb = new List<BreadcrumbItem>()
            {
                new BreadcrumbItem("Products", "Products", "Index"),
                new BreadcrumbItem(product.Name, "Products", "ProductById")

            };
            return View(product);   
        }
    }
}
