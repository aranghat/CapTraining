using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatesAsCallBack
{
    internal class Program
    {
        delegate void CallBack(string message);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file name :");
            string file = Console.ReadLine();

            Console.WriteLine("Where do you want to play (Mobile/TV/Stereo)");
            string playWhere = Console.ReadLine();

            CallBack callBack = null;

            switch (playWhere)
            {
                case "Mobile": callBack = PlayVideoInMobile;break;
                case "TV": callBack = PlayVideoInTV; break;
                case "Stereo": callBack = PlayVideoInStereo; break;
            }

            DownloadFile(file, callBack);
        }

        static void DownloadFile(string fileName,CallBack callback)
        {
            Console.WriteLine($"Starting to Download File {fileName}");
            Thread.Sleep(2000);
            Console.WriteLine("Completed downloading File");

            callback($"Download is completed");
        }

        static void PlayVideoInTV(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Playing Video in TV");
        }

        static void PlayVideoInMobile(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Playing Video in Mobile");
        }
        static void PlayVideoInStereo(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Playing Video in Stereo");
        }
    }
}
