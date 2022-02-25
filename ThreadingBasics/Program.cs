using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread displayNumberThread = new Thread(new ParameterizedThreadStart(DisplayNumbers));
            Thread downloadFile        = new Thread(new ThreadStart(DownloadFile));

            MyParams myParams = new MyParams { MaxCount = 20, Message = "THREAD 1" };

            displayNumberThread.Start(myParams);
            downloadFile.Start();

            //DisplayNumbers();
            //DownloadFile();

        }

        public class MyParams
        {
            public string Message { get; set; }
            public int MaxCount { get; set; }
        }

        public static void DisplayNumbers(object p)
        {
            MyParams myParams = (MyParams)p;
            for(int i=0;i<myParams.MaxCount;i++)
            {
                Console.WriteLine($"{myParams.Message} {i}");
                Thread.Sleep(100);
            }
        }

        public static void DownloadFile()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Download {i}");
                Thread.Sleep(100);
            }
        }
    }
}
