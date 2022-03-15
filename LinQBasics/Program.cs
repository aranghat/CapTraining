using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> list = new List<Customer>();
            list.Add(new Customer { Name = "Sree", Id = 1, Age = 35 });
            list.Add(new Customer { Name = "Bill", Id = 2, Age = 18 });
            list.Add(new Customer { Name = "Kate", Id = 3, Age = 23 });
            list.Add(new Customer { Name = "Emma", Id = 4, Age = 29 });

            List<CustomerAdress> address = new List<CustomerAdress>();
            address.Add(new CustomerAdress { Address = "Address 1", CustomerId = 1, Id = 1 });
            address.Add(new CustomerAdress { Address = "Address 2", CustomerId = 1, Id = 2 });
            address.Add(new CustomerAdress { Address = "Address 3", CustomerId = 2, Id = 3 });
            address.Add(new CustomerAdress { Address = "Address 4", CustomerId = 3, Id = 4 });

            #region basics
            /*
            //select * from customers where age > 18
            var customerList = from c in list
                               where c.Age >= 18 && c.Age <= 25
                               orderby c.Name descending
                               select c;


            foreach(var customer in customerList)
                Console.WriteLine($"{customer.Name} {customer.Id}");

            //select name,age from customers where age > 18
            var customerListByAge = from c in list
                               where c.Age >= 18 && c.Age <= 25
                               orderby c.Name descending
                               select new { c.Name, c.Age };


            foreach (var customer in customerListByAge)
                Console.WriteLine($"{customer.Name} {customer.Age}");
            */
            #endregion

            #region joins

            //var customerAddress = from c in list
            //                      join a in address on c.Id equals a.CustomerId
            //                      select new { Customer = c, Address = a };

            //foreach (var customer in customerAddress)
            //    Console.WriteLine($"{customer.Customer.Name} {customer.Address.Address}");


            //var customerAddress = from c in list
            //                      join a in address on c.Id equals a.CustomerId
            //                      select new { CustomerName = c.Name , Address = a.Address };

            //foreach (var customer in customerAddress)
            //    Console.WriteLine($"{customer.CustomerName} {customer.Address}");

            #endregion

            #region expressions

            //var customersbyAge = list.Where(d => d.Age >= 18 && d.Age <= 25);

            //foreach(var customer in customersbyAge)
            //    Console.WriteLine($"{customer.Name} {customer.Id}");

            //var customersbyAge2 = list.Where(d => d.Age >= 18 && d.Age <= 25).Select(d => new { d.Name, d.Age });

            //foreach (var customer in customersbyAge2)
            //    Console.WriteLine($"{customer.Name} {customer.Age}");

            #endregion

            #region Linq Aggregate

            //1. Avg
            //2. Min
            //3. Max
            //4. Count
            //5. Sum
            //6. Distinct

            var avgAge = list.Average(d => d.Age);
            Console.WriteLine(avgAge);

            var minAge = list.Min(d => d.Age);

            var avgAge2 = list.Where(d => d.Age > 25).Average(d => d.Age);

            #endregion
        }
    }
}
