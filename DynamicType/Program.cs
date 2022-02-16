using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The implicitly typed variable is known at the compile time itself
            //var a = 10;
            //var b = 20;

            //int c = a + b;

            //object d = 20;
            //object e = 20;

            object per = 70.0F;

            Console.WriteLine("Enter your final year marks in Percentage or Grade");
            string userInput = Console.ReadLine();

            dynamic studentFinalYearResult;

            float studentPercentage;
            if (float.TryParse(userInput, out studentPercentage))
                studentFinalYearResult = studentPercentage; //Assigning a float
            else
                studentFinalYearResult = userInput; //Assigning a string

            //Is just chekes is the data type if compatable 
            if (studentFinalYearResult is float)
            {
                //It will try to convert the data to the other data type 
                //If conversion is not successful it will return null
                var percentageInNumber = studentFinalYearResult as float?;

                if (studentFinalYearResult >= 70.0F)
                    Console.WriteLine("You have been selected");
            }
            else
                if (studentFinalYearResult == "B" || studentFinalYearResult == "A")
                     Console.WriteLine("You have been selected");


        }
    }
}
