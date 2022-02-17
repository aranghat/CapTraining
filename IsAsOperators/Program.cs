using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAsOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic accountBalance = "NEGATIVE";

            if(accountBalance is float)
            {
                float? balance = accountBalance as float?;

                if(balance.HasValue)
                {
                    balance = balance + 50000;
                }
                Console.WriteLine("Account balance can be converted to float");
            }


        }
    }
}
