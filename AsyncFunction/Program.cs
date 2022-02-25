using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniating file downlod");
            var fileName = DownloadFile();

            fileName.ContinueWith(d =>
                {
                    Console.WriteLine("Download Completed");
                    ProcessFile(d.Result);
                }
            );
                               

            Console.WriteLine("Menwhile tell me your name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hey {name} sorry the file is taking a lot of time");

            Console.ReadLine();

        }

        static async Task<string> DownloadFile()
        {
            string fileName = "test.jpeg";

            Console.WriteLine("Downloading file");
            await Task.Delay(10000);
            Console.WriteLine("Download completed");
            return fileName;
        }

        static async Task<string> ProcessFile(string fileName)
        {
            Console.WriteLine($"Processing {fileName}");
            await Task.Delay(5000);
            Console.WriteLine($"Process Completed for {fileName}");
            return "Process Completed";
        }
    }
}
