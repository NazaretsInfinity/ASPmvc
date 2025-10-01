using Filters_HW.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Filters_HW.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index1()
        {
            return View();
        }
    }
}
