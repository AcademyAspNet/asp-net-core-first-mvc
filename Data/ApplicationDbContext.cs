using Microsoft.EntityFrameworkCore;
using MyFirstMvc.Data.Entities;

namespace MyFirstMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        private const string DEFAULT_CONNECTION_STRING_NAME = "Default";

        public DbSet<Person> Persons { get; set; }

        private readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (optionsBuilder.IsConfigured)
                return;

            string? connectionString = _configuration.GetConnectionString(DEFAULT_CONNECTION_STRING_NAME);

            if (string.IsNullOrEmpty(connectionString))
                throw new MissingFieldException($"Failed to get connection string with name '{DEFAULT_CONNECTION_STRING_NAME}'");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
