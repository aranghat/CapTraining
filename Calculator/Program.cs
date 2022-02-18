using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        /* public    - The members/methods can be accessed any where in the application
         * private   - These members are only visible with in the class
         * protected - These are members that can be accessed only by the same class or classes
         *             that inherit from it
         * internal - These members which can be accessed with in the same assembly.
         *            They act as public with in the same assembly but private for opther assemblies
         * protected internal - Combines the propery of protected and internal
         */

        static void Main(string[] args)
        {
            CalculationLogic calculationLogic = new CalculationLogic();

            int sum      = calculationLogic.Add(10, 20);
            int subtract = calculationLogic.Subtract(10, 20);

            Console.WriteLine(sum);
            Console.WriteLine(subtract);

            CalculateValues va = new CalculateValues();
            va.RandomValue = 465;
           
            va.PrintPrivateValue();

            DisplayParameters dis = new DisplayParameters();
            
        }
    }
}
