using OnlineStore_HW.Services;
using OnlineStore_HW.Services.Implementations;

namespace OnlineStore_HW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IProductService,ProductService>();
           
            var app = builder.Build();
            app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
