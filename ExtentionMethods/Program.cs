using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name     = "Sreehari";
            employee.Email    = "sree@gmail.com";
            employee.Id       = 10001;

            employee.DisplayDetails(true);

            Employee employee2 = new Employee();
            employee2.Name = "Bill";
            employee2.Email = "bill@gmail.com";
            employee2.Id = 10002;

            employee.DisplayDetails(false);

            string data = "Hello World";
            data.WordCount();
           
        }
    }

    public static class EmployeeExtentions
    {
        public static void DisplayDetails(this Employee employee
                                         ,bool includeId)
        {
            if (includeId)
            {
                Console.WriteLine($@"Name : {employee.Name}
                                Email : {employee.Email}
                                EmployeeId : {employee.Id}");
            }
            else
                Console.WriteLine($@"Name : {employee.Name}
                                Email : {employee.Email}");
                               
        }
    }

    public static class StringExtentions
    {
        public static int WordCount(this string str)
        {
            int wordCount = str.Split(' ').Length;
            return wordCount;
        }
    }
}
