using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    //1. While Loop
    //2. Do While Loop
    //3. For Loop
    //4. For Each Loop
    internal class Program
    {
        static void Main(string[] args)
        {
            #region whileloop
            /*
            int count = 0;
            int sum = 0;
            while (count < 5)
            {
                //Console.WriteLine($"{count}");
                //count = count + 1;
                string userInput  = Console.ReadLine();
                int input         = int.Parse(userInput);

                sum               += input;// sum = sum + input
                count++;
            }

            Console.WriteLine($"Total sum is : {sum}");*/


            #endregion

            #region dowhile

            /*
            string choice  = "YES";
            int totalmarks = 0;

            do
            {
                Console.Write("Enter Marks : ");
                string userInput  = Console.ReadLine();
                int marks         = int.Parse(userInput);

                totalmarks        += marks;

                Console.Write("Do you have more marks to enter (YES/NO) : ");
                choice = Console.ReadLine();
            } 
            while (choice == "YES");
            
            Console.WriteLine($"Total Marks : {totalmarks}");*/

            #endregion

            #region forloop

            //for (int count = 0; count < 10; count++)
            //{
            //    Console.WriteLine($"{count}");
            //}

            #endregion

            #region PrimeNumbers

            Console.WriteLine("Enter the max limit :");
            string userInput = Console.ReadLine();
            int maxLimit     = int.Parse(userInput);

            for (int i = 2; i <= maxLimit; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    Console.WriteLine(i);
            }


            #endregion

        }
    }
}
