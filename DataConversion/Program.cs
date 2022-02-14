using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your age : ");
            string userInput =  Console.ReadLine();

            Console.Write("Enter your annual income :");
            string userAnnualIncome = Console.ReadLine();

            Console.Write("Are you applying for scholar ship");
            string userScholarShip = Console.ReadLine();

            bool isAppliedForScholarShip;
            if(bool.TryParse(userScholarShip,out isAppliedForScholarShip))
                Console.WriteLine("Applied for Scholar Ship");

            /*
                int age          = int.Parse(userInput);
                Console.WriteLine(age + 10);
            */

            /*
             * Below we validate the user input before addition
            */

            int age;
            int annualIncome;

            

            if(int.TryParse(userInput,out age) && int.TryParse(userAnnualIncome,out annualIncome))
                Console.WriteLine(age + 10);
            else
                Console.WriteLine("The input you provided is not a valid number");
        }
    }
}
