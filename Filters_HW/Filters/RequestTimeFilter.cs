using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace Filters_HW.Filters
{
    public class RequestTimeFilter : Attribute, IActionFilter
    {
        private readonly ILogger<RequestTimeFilter> _logger;
        private Stopwatch? _stopwatch;

        public RequestTimeFilter(ILogger<RequestTimeFilter> logger)
        {
            _logger = logger;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            _stopwatch?.Stop();
            string? actionName = context.ActionDescriptor.DisplayName;            
            
            Console.WriteLine($"action {actionName} was proccesed in  {_stopwatch?.ElapsedMilliseconds} milliseconds");

            if (_stopwatch?.ElapsedMilliseconds > 500)
                _logger.LogWarning(message: $"Action {actionName} took more than 5 seconds");
         
        }

        public  void OnActionExecuting(ActionExecutingContext context)
        {
            _stopwatch = Stopwatch.StartNew();
        }
    }
}
