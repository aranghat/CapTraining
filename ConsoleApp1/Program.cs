using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<10000000000;i++)
            {
                Employee employee = new Employee();
                employee.Id = i;
                employee.Name = "Sree";
            }

            Console.ReadLine();
        }

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public byte[] Photo = new byte[1024];
        }
    }
}
