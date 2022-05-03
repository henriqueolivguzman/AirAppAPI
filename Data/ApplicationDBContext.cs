using Microsoft.EntityFrameworkCore;
using Business.Models;
using System.ComponentModel.Design;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {  }
        
        public virtual DbSet<Aircraft> Aircrafts { get; set; }
        public virtual DbSet<Aircraft> Engines { get; set; }
        public virtual DbSet<Aircraft> Users { get; set; }

        
    }
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDBContext>
    {
        public ApplicationDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory()+
            "/../AirAppAPI/appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<ApplicationDBContext>();
            var connectionString = configuration.GetConnectionString("DatabaseConnection");
            builder.UseSqlServer(connectionString);

            return new ApplicationDBContext(builder.Options);
        }
    }
}