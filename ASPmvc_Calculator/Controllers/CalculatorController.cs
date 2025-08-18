using Microsoft.AspNetCore.Mvc;

namespace ASPmvc_Calculator.Controllers
{
    [Controller]
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate()
        {
            return View();
        }
    }
}
