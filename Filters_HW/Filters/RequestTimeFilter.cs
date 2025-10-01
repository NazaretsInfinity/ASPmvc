using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace Filters_HW.Filters
{
    public class RequestTimeFilter : Attribute, IActionFilter
    {
        private readonly ILogger<RequestTimeFilter> _logger;
        private Stopwatch? _stopwatch;
        private Timer? _timer;

        public RequestTimeFilter(ILogger<RequestTimeFilter> logger)
        {
            _logger = logger;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            _stopwatch?.Stop();
            _timer?.Dispose();
            string? actionName = context.ActionDescriptor.DisplayName;            
            
            Console.WriteLine($"action {actionName} was proccesed in  {_stopwatch?.ElapsedMilliseconds} milliseconds");
         
        }

        public  void OnActionExecuting(ActionExecutingContext context)
        {
            _stopwatch = Stopwatch.StartNew();

            _timer = new Timer(a => 
            {
                    if (_stopwatch?.IsRunning == true)   
                    _logger.LogWarning("Action is executing for more than 5 seconds");
            }, 
            null, 500, Timeout.Infinite);
        }
    }
}
