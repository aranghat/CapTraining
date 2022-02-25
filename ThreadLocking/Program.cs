using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLocking
{
    internal class Program
    {
        static List<int > list = new List<int>();
        static object locker = new object();
        static void Main(string[] args)
        {
            Thread thread1= new Thread(new ThreadStart(ProcessNumbers));
            Thread thread2 = new Thread(new ThreadStart(ProcessNumbers));

            thread1.Start();
            thread2.Start();
        }

        public static void ProcessNumbers()
        {
            lock (locker)
            {
                //Add numbers to the list 
                if (list.Count == 0)
                    for (int i = 0; i < 20; i++)
                    {
                        Console.WriteLine(i);
                        list.Add(i);
                    }
            }

            //Add Sum of items in the list
            if(list.Count > 0)
            {
                int totalSum = 0;
                foreach (int i in list)
                    totalSum += i;

                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Total Sum of numbers is : {totalSum}");
            }
        }
    }
}
