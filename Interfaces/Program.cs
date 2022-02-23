using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file name to play");
            string fileNAme = Console.ReadLine();

            Console.WriteLine("Pick Your Device");
            string devideName = Console.ReadLine();

            IVideoPlayer player = GetPlayer(devideName);
            player.Play();
        }

        static IVideoPlayer GetPlayer(string deviceName)
        {
            IVideoPlayer player = null;

            switch(deviceName)
            {
                case "VideoPlayer": player = new VideoPlayer(); break;
                case "MobilePhone": player = new MobilePhone();  break;
                case "Tablet"     : player = new Tablet(); break;
            }

            return player;
        }
    }
}
