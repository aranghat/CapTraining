using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ifstatements
            /*
            string userInput = Console.ReadLine();
            int annualIncome = int.Parse(userInput);

            string userInputemployeeType = Console.ReadLine();
            bool isGovtEmployee = bool.Parse(userInputemployeeType);

            //1. If Else
            //&& AND if both condition has to be validated
            //|| OR if any one of the condition is valid
            if ((annualIncome < 200000 || annualIncome > 100000) || isGovtEmployee == true)
            {
                Console.WriteLine("You are under taxable income slab");
                Console.WriteLine("Remember to pay before March 31");
            }
            else if (annualIncome < 1000000)
            {
                Console.WriteLine("Please check with the auditor");
            }
            else
                Console.WriteLine("You dont have to pay taxes");*/

            #endregion

            #region switchstatemetns

            //2. Switch Statements

            /*
            Console.Write("Which day is it");
            string weekDay = Console.ReadLine();

            switch (weekDay)
            {
                case "Monday"    : Console.WriteLine("Start of the week. Awsome");break;
                case "Tuesday"   : Console.WriteLine("Going great"); break;
                case "Wednesday" : Console.WriteLine("Almost half of week"); break;
                case "Thursday"  : Console.WriteLine("Lets finish pending work"); break;
                case "Friday"    : Console.WriteLine("Thank god its friday"); break;
                case "Saturday"  : 
                case "Sunday"    : Console.WriteLine("Weekend"); break;
                default: Console.WriteLine("Looks like its not a weekday"); break;
            }*/

            #endregion

            //3. Conditional Statement ?
            Console.Write("Enter your age : ");
            string userInput = Console.ReadLine();
            int age          = int.Parse(userInput);

            //if(age >= 18)
            //    Console.WriteLine("You are eligible to vote");
            //else
            //    Console.WriteLine("You must be atleast 18 years to vote");

            //Condition ? Statement if condition is true : Statement if condition is false
            string message = age >= 18 ? "You are eligible to vote" : "You must be atleast 18 years to vote";
            Console.WriteLine(message);

        }
    }
}
