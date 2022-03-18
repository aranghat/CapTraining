using HelloEfCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloEfCore
{
    public class EcomDataContext : DbContext
    {
        public static ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddDebug());


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products   { get; set; }
        public DbSet<Order> Orders       { get; set; }
         
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(loggerFactory);

            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Server=." +
                ";DataBase=myecomsite");
        }
    }
}
