using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  1. Single Dimentional Array
             *  2. Multi Dimentional Array
             *  3. Jagged Array
             */

            #region Single Dimentional Array

            /*
            int[] intArray = new int[10]; //Declare a array

            intArray[0] = 10;
            intArray[1] = 20;
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;

            //for(int i=0;i<intArray.Length;i++)
                //Console.WriteLine(intArray[i]);

            foreach(var value in intArray)
                Console.WriteLine(value);

            string[] deliveryLocations =  {"Bangalore", "Delhi", "Mumbai"};

            deliveryLocations[2] = "Kolkata";


            foreach (var city in deliveryLocations)
            {
                Console.WriteLine(city);
            }*/

            #endregion

            #region multi dimentional array

            int[,] twoDimentionalArray = new int[10, 2];

            /*---------------------------Row 1------------------*/
            twoDimentionalArray[0,0]  = 1;
            twoDimentionalArray[0,1] = 11;
           

            /*---------------------------Row 2------------------*/
            twoDimentionalArray[1, 0] = 2;
            twoDimentionalArray[1, 1] = 12;


            //for (int row = 0; row < 10; row++)
            //{
            //    for (int col = 0; col < 2; col++)
            //    {
            //        Console.Write(twoDimentionalArray[row,col] + " ");
            //    }

            //    Console.WriteLine("");
            //}

            //foreach (var data in twoDimentionalArray)
            //{
            //    Console.Write(data + " ");
            //}

            //string[,] citiesAndCapital =
            //{
            //    {"Karnataka", "Bangalore"}, {"Maharastra", "Mumbai"}, {"Kerala", "Trivandrum"}
            //};

            //for (int row = 0; row < 3; row++)
            //{
            //    Console.WriteLine($"STATE : {citiesAndCapital[row,0]}, CAPITAL : {citiesAndCapital[row, 1]}");
            //}

            #endregion

            #region Jagged Array

            //int [][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[] {10, 11, 21, 31, 41};
            //jaggedArray[1] = new int[] {34, 51};
            //jaggedArray[2] = new int[] {1, 2, 3, 4, 5, 6, 7};

            int[][] jaggedArray =
            {
                new int[] {10, 11, 21, 31, 41},
                new int[] {34, 51},
                new int[] {1, 2, 3, 4, 5, 6, 7}
            }; 

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }

                foreach (var rowData in jaggedArray[row])
                {
                    Console.Write($"{rowData} ");
                }

                Console.WriteLine();
            }

            #endregion

        }
    }
}
