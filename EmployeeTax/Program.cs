using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1     = new Employee();
            emp1.name         = "Sreeharui";
            emp1.annualincome = 500000;
            emp1.gender       = Gender.Male;
            emp1.id           = 1;

            Employee emp2     = new Employee();
            emp2.name         = "Kate";
            emp2.annualincome = 700000;
            emp2.gender       = Gender.Female;
            emp2.id           = 2;

            emp1.DisplayDetails();
            emp2.DisplayDetails();


        }
    }
}
