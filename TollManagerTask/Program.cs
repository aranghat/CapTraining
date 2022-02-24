using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollManagerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TollManager tollManager = new TollManager();
            tollManager.OnTollCollected += TollManager_OnTollCollected;

            tollManager.CollectToll(new Vechile { VechileType = VechileType.TwoWeeler, VechileNumber = "ABCD" });
            tollManager.CollectToll(new Vechile { VechileType = VechileType.FourWeeler, VechileNumber = "ABCD" });
            tollManager.CollectToll(new Vechile { VechileType = VechileType.FourWeeler, VechileNumber = "ABCD" });
            tollManager.CollectToll(new Vechile { VechileType = VechileType.TwoWeeler, VechileNumber = "ABCD" });
            tollManager.CollectToll(new Vechile { VechileType = VechileType.Cargo, VechileNumber = "ABCD" });
        }

        private static void TollManager_OnTollCollected(Vechile vechile, int tollAmount, int totalTollCollected)
        {
            Console.WriteLine($"Vechile : {vechile.VechileNumber}, Type : {vechile.VechileType}" +
                $", Toll : {tollAmount}, Total Amount : {totalTollCollected}");
        }
    }
}
