using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefNOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int abc;

            Console.WriteLine($"1.Before Calling Method: {x}");
            IncrementNumber(ref x);
            Console.WriteLine($"4.After Calling  Method: {x}");

           
            IncrementOutNumber(out abc);
            Console.WriteLine($"4.After Calling  Method: {abc}");

            int annualIncome = 500000;
            float tax;
            float taxableAmount;

            CalculateTax(annualIncome,out tax, out taxableAmount);
        }

        //1. Its is mandatory to initialize the variable
        //2. There is no requirement that variable need to be initialized
        //3. This data flow is bi directional
        static void IncrementNumber(ref int y)
        {
            Console.WriteLine($"2.Before Modifying Inside Method: {y}");
            y = y * 2;
            Console.WriteLine($"3.After Modifying Inside Method: {y}");
        }

        //1. Its not mandatory to initialize the variable
        //2. The variable need to initialized inside the method
        //3. Data flow is unidirectional 
        static void IncrementOutNumber(out int y)
        {
            y = 100;
            Console.WriteLine($"2.Before Modifying Inside Method: {y}");
            y = y * 2;
            Console.WriteLine($"3.After Modifying Inside Method: {y}");
        }

        //Using out to return multiple values
        static void CalculateTax(int annualIncome, out float tax, out float taxableAmount)
        {
            tax           = .20F;
            taxableAmount = annualIncome * tax;
        }
    }
}
