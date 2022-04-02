using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginBasics.Models
{
    public class CustomerRepository
    {
        List<Customer> customers = new List<Customer>();

        public CustomerRepository()
        {
            customers.Add(new Customer { Id = 1001, Email = "sreehariis@gmail.com", Name = "Sree", Password = "1234" });
            customers.Add(new Customer { Id = 1002, Email = "bill@gmail.com", Name = "Bill", Password = "1234" });
            customers.Add(new Customer { Id = 1003, Email = "steve@gmail.com", Name = "Steve", Password = "1234" });
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }

        public Customer FindByUserNamePassword(string username,string password)
        {
            return customers.FirstOrDefault(d => d.Email == username && password == password);
        }
    }
}