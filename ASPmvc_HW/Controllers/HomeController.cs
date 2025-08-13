using ASPmvc_HW.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace ASPmvc_HW.Controllers
{
    [Controller]
    public class HomeController : Controller
    {

        public string Index() => "Hello, world!";

        [HttpGet]
        public IActionResult Welcome([FromServices] IGreetingService greetingService)
        {
            return Content($"<h1 style=\"text-align:center\">{greetingService.GetWelcomeMessage()}</h1>", "text/html", Encoding.UTF8);
        }

        [ActionName("Time")]
        public IActionResult PrintDateTime()
        {
            string html = $"<h1 style='text-align:center'>Today: {DateTime.Now}</h1>";
            return Content(html , "text/html", Encoding.UTF8);
        }
    }
}
