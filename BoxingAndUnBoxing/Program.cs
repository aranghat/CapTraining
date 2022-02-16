using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object x = 10;
            x = "Hello world";

            int a = 10; // Value Type

            //Everything in C# derives from System.Object
            object b = 10; // Reference Type
            object str = "Hello World";
            object tax = .30F;

          

            object count = a;// Storing a value type in to a reference type
                             // Boxing

            Console.WriteLine(b.GetType());
            Console.WriteLine(str.GetType());
            Console.WriteLine(tax.GetType());

            int newCounter = (int)count;// Convert a reference type to value type
                                        // Unboxing

            string[,] marks = new string[2, 10];
            marks[0, 0] = "English";
            marks[0, 1] = "50";

            object [,] marksObjects = new object[2, 10];

            marksObjects[0, 0] = "English";
            marksObjects[0, 1] = 50;

            marksObjects[1, 0] = "Maths";
            marksObjects[1, 1] = 70;

            int totalMarks = (int)marksObjects[0, 1] + (int)marksObjects[1, 1];


        }

        
    }
}
