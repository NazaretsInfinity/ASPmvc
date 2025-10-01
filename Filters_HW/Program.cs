using Filters_HW.Filters;
using Microsoft.Extensions.Options;

namespace Filters_HW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

           
            builder.Services.AddControllersWithViews(options =>
            options.Filters.Add<RequestTimeFilter>()
            );

            var app = builder.Build();
            app.MapControllerRoute("default", "{controller=Home}/{action=Index}");
            
 
            app.UseStaticFiles();
            app.Run();
        }
    }
}
