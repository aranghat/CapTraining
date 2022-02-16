using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int? initialBalance = null;
            initialBalance = 5000;
            //OpenBankAccount(initialBalance);

            int?[] marks = new int?[10];
            marks[0] = 50;
            marks[1] = 60;

            foreach(int? i in marks)
                if(i.HasValue)
                Console.WriteLine(i);

        }

        static void OpenBankAccount(int? initialBalance)
        {
            //if(initialBalance.HasValue)
            //{
            //    Console.WriteLine($"You already have given initial balance of {initialBalance}");
            //}
            //else
            //{
            //    Console.Write("Please provide initial amount :");
            //    string userInput = Console.ReadLine();
            //    initialBalance = int.Parse(userInput);
            //}

            initialBalance = initialBalance ?? int.Parse(Console.ReadLine());
            Console.WriteLine($"You already have given initial balance of {initialBalance}");

        }
    }
}
