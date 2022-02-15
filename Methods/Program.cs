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
            var str = Console.ReadLine(); //Implicitly typed variable

            var balance = DepositAmount(
                 amount: 10000 /*Named Parameter*/
                , intrestRate: 10
                , initialBalance: 1000);

            //DepositAmount(10000, 10, 1000);

            Console.WriteLine($"Current Balance is {balance}");
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

        static float DepositAmount(float amount
            , float initialBalance = 0 /*Optional Parameter*/
            , float intrestRate = 0.0F /*Optional Parameter*/)
        {
            var currentBalance = initialBalance + amount;
            return currentBalance;
        }
    }
}
