using MyFirstMvc.Data.Entities;
using MyFirstMvc.Data.Repositories;
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

            builder.Services.AddScoped<IRepository<Person>, PersonRepository>();
            builder.Services.AddScoped<ICompanyService, CompanyService2>();

            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllers();

            app.Run();
        }
    }
}
