using HelloEfCore.Entities;
using System;

namespace HelloEfCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EcomDataContext context = new EcomDataContext();

            /*Customer customer = new Customer();
            customer.Address = "Address 1";
            customer.Name = "Sreehari Aranghat";
            
            context.Customers.Add(customer);
            context.SaveChanges();*/

            foreach (var item in context.Customers)
                Console.WriteLine($"{item.Name} {item.Address}");
        }
    }
}
