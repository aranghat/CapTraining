using HelloEfCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace HelloEfCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EcomDataContext context = new EcomDataContext();

            /*
            Customer c1 = new Customer("Sree","Address 1", "sreehariis@gmail.com");
            Customer c2 = new Customer("Bill", "Address 2", "bill@gmail.com");
            Customer c3 = new Customer("Mark", "Address 1", "mark@gmail.com");
       
            context.Customers.AddRange(c1,c2,c3);

            context.Products.Add(new Product("Coffee",10,50.5F));
            context.Products.Add(new Product("Tea", 10, 40));
            context.Products.Add(new Product("Sugar", 10, 35));
            context.Products.Add(new Product("Washing Powder", 10, 100F));*/

            //context.SaveChanges();

            //foreach (var item in context.Customers)
            //    Console.WriteLine($"{item.Name} {item.Address} {item.Email}");

            //foreach (var item in context.Products.Where(d => d.UnitPrice >= 50))
            //    Console.WriteLine($"{item.Name} {item.UnitPrice} {item.TotalAvailableQuantity}");

            //1. Avg
            //2. Min
            //3. Max
            //4. Count
            //5. Sum
            //6. Distinct

            //var avgPriceOfProducts = context.Products.Average(d => d.UnitPrice);
            //Console.WriteLine($"Avg Price of Products = {avgPriceOfProducts}");

            //var product     = context.Products.FirstOrDefault(d => d.Id == 9);
            //var customer    = context.Customers.FirstOrDefault(d => d.Id == 1);

            //if (product != null && customer != null)
            //{
            //    Order order = new Order();
            //    order.Product = product;
            //    order.Customer = customer;
            //    order.OrderDate = DateTime.Now;
            //    order.Quantity = 2;
            //    order.TotalPrice = product.UnitPrice * order.Quantity;

            //    context.Orders.Add(order);
            //    context.SaveChanges();
            //}

            //var orders = context.Orders.Include(d => d.Customer)
            //                           .Include(d => d.Product);

            //foreach (var order in orders)
            //{
            //    Console.WriteLine($"{order.Id} {order.Customer.Name} {order.Product.Name} {order.Quantity} {order.TotalPrice}");
            //}

            //var customer = context.Customers.FirstOrDefault(d => d.Id == 1);
            //if(customer != null)
            //{
            //    customer.Email = "sree@gmail.com";
            //    context.Customers.Update(customer);
            //    context.SaveChanges();
            //}

            //var customerToDelete = context.Customers.FirstOrDefault(d => d.Id == 4);
            //if (customerToDelete != null)
            //{

            //    context.Customers.Remove(customerToDelete);
            //    context.SaveChanges();
            //}

            //var orders = context.Orders.Where(d => d.Customer.Id == 1);
            //foreach(var order in orders)
            //{
            //    order.DeliveryStatus = "DELIVERED";
            //    context.Orders.Update(order);
            //}

            //context.SaveChanges();  

            var transacton = context.Database.BeginTransaction();

            try
            {

                int retValue = context.Database.ExecuteSqlRaw("update orders set deliverystatus='Delivered' where customerid=1");
                if (retValue > 0)
                {
                    Console.WriteLine("Update was successful");
                }

                transacton.Commit();
            }
            catch (Exception ex)
            {
                transacton.Rollback();
            }
        }
    }
}
