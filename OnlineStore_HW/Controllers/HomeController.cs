using Microsoft.AspNetCore.Mvc;

namespace OnlineStore_HW.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
