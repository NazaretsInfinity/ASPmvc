using Microsoft.AspNetCore.Mvc;

namespace MvcHelpers_HW.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
