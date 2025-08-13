using ASPmvc_HW.Services;
using ASPmvc_HW.Services.Implementations;

namespace ASPmvc_HW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddSingleton<IGreetingService,GreetingService>();
            
            var app = builder.Build();
            app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
