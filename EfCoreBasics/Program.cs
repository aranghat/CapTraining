using System;
using System.Collections.Generic;

namespace EfCoreBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(Customer c in GetCustomers())
                Console.WriteLine(c);
        }

        static List<Customer> GetCustomers()
        {
            return new List<Customer>();
        }
    }
}
