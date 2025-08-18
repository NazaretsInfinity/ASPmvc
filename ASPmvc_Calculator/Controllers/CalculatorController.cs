using Microsoft.AspNetCore.Mvc;

namespace ASPmvc_Calculator.Controllers
{
    [Controller]
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index(double? result, string? errorMessage)
        {
            ViewBag.Result = result;
            ViewBag.Error = errorMessage; 
            return View();
        }

        [HttpPost]
        public IActionResult Calculate([FromForm] double num1, [FromForm] double num2, [FromForm] string operation)
        {
            double result = 0;

            try
            {
                switch (operation)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "*": result = num1 * num2; break;
                    case "/":
                        if (num2 == 0)
                            throw new DivideByZeroException("Can't divide by zero");
                        result = num1/num2; 
                        break;
                }

                return RedirectToAction("Index", new { result });
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", new { errorMessage = ex.Message });
            }

        }
    }
}
