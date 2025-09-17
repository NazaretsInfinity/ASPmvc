using Microsoft.AspNetCore.Mvc;
using OnlineStore_HW.Models.DTO;
using OnlineStore_HW.Models.Utils;
using OnlineStore_HW.Services;
using OnlineStore_HW.Models.Views;
using OnlineStore_HW.Models.Entities;

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


            ProductView model = new ProductView()
            {
                Product = product,
                ReviewDTO = new ReviewDTO()
            };

            ViewBag.Breadcrumb = new List<BreadcrumbItem>()
            {
                new BreadcrumbItem("Products", "Products", "Index"),
                new BreadcrumbItem(product.Name, "Products", "ProductById")

            };
            return View(model);   
        }

        [HttpPost]
        public IActionResult AddReview([FromForm]ReviewDTO review)
        {
            if(!ModelState.IsValid) return Content($"Errors: {ModelState.ErrorCount}");

            return Content($"{review.Author}: {review.Text}");
        }
    }
}
