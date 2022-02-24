using System;
using System.IO;
using System.Net;

namespace FilenFolderBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var basePath = @"D:\CapTraining\DataTypes";
            //var directories = new DirectoryInfo(basePath).GetDirectories();

            //foreach (var d in directories)
            //{
            //    Console.WriteLine($"{d.Name} -  {d.FullName} - {d.GetFiles().Length}");

            //    //foreach (var subFolder in new DirectoryInfo(d.FullName).GetDirectories())
            //    //{
            //    //    Console.WriteLine($"\t -> {subFolder.Name}");
            //    //}

            //    foreach (var files in new DirectoryInfo(d.FullName).GetFiles("*.cs"))
            //    {
            //        Console.WriteLine($"\t -> {files.Name}  {files.Extension}  {files.Length}");
            //    }

            //}

            //Console.WriteLine("Enter your notes here");
            //string userInput = Console.ReadLine();

            ////File.WriteAllText(@"D:\CapTraining\mynotes.txt", userInput);
            //File.AppendAllText(@"D:\CapTraining\mynotes.txt", userInput);

            //Console.WriteLine("Enter the file Path :");
            //string filePath = Console.ReadLine();

            //var fileContent = File.ReadAllText(filePath);
            //Console.WriteLine(fileContent);

            WebClient client = new System.Net.WebClient();
            var dataFromInternet = client.DownloadString(@"https://www.rfc-editor.org/rfc/rfc3261.txt");

           // StreamReader reader = new StreamReader();
            //foreach(var line in reader.ReadLine())
            //    Console.WriteLine(line);

            StreamWriter sw = new StreamWriter(@"D:\CapTraining\datafrominternet.txt");
            sw.WriteLine(dataFromInternet);
            sw.Close();


        }
    }
}
