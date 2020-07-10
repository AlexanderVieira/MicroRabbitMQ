        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.IO;
        using System.Threading.Tasks;
        using Microsoft.EntityFrameworkCore;
        using Microsoft.Extensions.Configuration;
        using AVS.MicroRabbitmq.Domain.Banking.Models;                
        
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