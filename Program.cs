using MyFirstMvc.Data;
using MyFirstMvc.Data.Entities;
using MyFirstMvc.Models.Dto;
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
            builder.Services.AddDbContext<ApplicationDbContext>();

            builder.Services.AddScoped<IPersonService, PersonService>();
            builder.Services.AddScoped<ICompanyService, CompanyService2>();

            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllers();

            app.Run();
        }
    }
}
