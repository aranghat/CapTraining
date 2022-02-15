using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //int firstNumber  = 10;
            //int secondNumber = 20;

            //int sum          =  AddNumbers(firstNumber,secondNumber);
            //Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");

            //float balance = DepositAmount(10000, 1000);

            //string str = Console.ReadLine();
            //var str = Console.ReadLine(); //Implicitly typed variable

            //var balance = DepositAmount(
            //     amount: 10000 /*Named Parameter*/
            //    , intrestRate: 10
            //    , initialBalance: 1000);

            //DepositAmount(10000, 10, 1000);

            //Console.WriteLine($"Current Balance is {balance}");

            Console.Write("Enter your annual income : ");
            var userInput = Console.ReadLine();
            var annualIncome = int.Parse(userInput);

            var taxPercentage   = CalculateTax(annualIncome);
            var totalTaxPayable = CalculateTaxAmount(annualIncome, taxPercentage);

            DisplayTaxInformation(annualIncome,taxPercentage,totalTaxPayable);
        }
        #region simplemethos

        /*
       //Signature of a method - ReturnType NameOfTheMethod(Parameters)
       static int AddNumbers(int a, int b)
       {
           DisplayInformation(a,b);
           return a + b;
       }

       static void DisplayInformation(int a, int b)
       {
           Console.WriteLine($"Adding {a} + {b} at {DateTime.Now}");
       }

       */

        #endregion

        //1. Optional parameters should come only after all regular parameters

        //static float DepositAmount(float amount
        //    , float initialBalance = 0 /*Optional Parameter*/
        //    , float intrestRate = 0.0F /*Optional Parameter*/)
        //{
        //    var currentBalance = initialBalance + amount;
        //    return currentBalance;
        //}
        static float CalculateTax(int annualIncome)
        {
            float tax = 0.0F;

            if (annualIncome >= 200000 && annualIncome < 500000)
                tax = .10F;
            else if (annualIncome >= 500000 && annualIncome < 700000)
                tax = .20F;
            else if (annualIncome >= 700000)
                tax = .30F;

            return tax;
        }
        static float CalculateTaxAmount(int annualIncome, float tax)
        {
            return annualIncome * tax;
        }
        static void DisplayTaxInformation(int annualIncome, float tax, float taxAmount)
        {
            Console.WriteLine($"Annual Income : {annualIncome}, Tax Per : {tax}, Tax Amount : {taxAmount}");
        }
    }
}
