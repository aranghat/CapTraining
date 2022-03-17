using HelloEfCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloEfCore
{
    public class EcomDataContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products   { get; set; }
        public DbSet<Order> Orders       { get; set; }
         
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Server=." +
                ";DataBase=myecomsite");
        }
    }
}
