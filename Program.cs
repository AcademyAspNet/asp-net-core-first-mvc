using MyFirstMvc.Services;
using MyFirstMvc.Services.Implementations;

namespace MyFirstMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<ICompanyService, CompanyService2>();

            var app = builder.Build();

            //app.MapControllers();

            app.MapControllerRoute("areas", "{area:exists}/{controller=Home}/{action=Index}");
            app.MapControllerRoute("default", "{controller=Home}/{action=Index}");

            app.Run();
        }
    }
}
