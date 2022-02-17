using System;
using System.Diagnostics;

namespace DebugBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(@"D:\CapTraining\Log\mylogfile.txt"));
            Trace.Listeners.Add(new EventLogTraceListener("My Awsome Application"));
            Trace.AutoFlush = true;

            Debug.WriteLine($"Application is waiting for user input {DateTime.Now}");
            
            Console.WriteLine("Enter a max limit :");
            string userInput = Console.ReadLine();
            
            //Debug is going to execute only if the application is in DEBUG MODE
            Debug.WriteLine($"User input revieved at {DateTime.Now}");

            //Trace will execute if the application is in DEBUG OR Release Mode
            Trace.WriteLine($"User has given {userInput} as max value");

            int maxLimit     = int.Parse(userInput);

            for(int i = 0; i < maxLimit; i++)
            {
                int x = new Random().Next(100, 999);
                int y = new Random().Next(1000, 9999);


                int retValue = Add(x, y);
                Console.WriteLine($"X: {x} +  Y:{y} = {retValue}");

                Trace.WriteLine($"X: {x} +  Y:{y} = {retValue}");
            }

            Console.ReadLine();
        }

        static int Add(int x,int y)
        {
            int sum = x + y;
            return sum;
        }
    }
}
