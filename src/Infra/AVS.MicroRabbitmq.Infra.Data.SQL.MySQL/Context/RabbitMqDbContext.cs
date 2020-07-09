using Microsoft.EntityFrameworkCore;
using AVS.MicroRabbitmq.Domain.Banking.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AVS.MicroRabbitmq.Infra.Data.SQL.MySQL.Context
{
    public class RabbitMqDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.RemovePluralizingTableNameConvention();
            //modelBuilder.ApplyConfiguration(new EducatorMap());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            
            optionsBuilder.UseMySql(config["ConnectionStrings:connStrMySql"]);            
        }        
    }
}