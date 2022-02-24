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
        }

        private static void TollManager_OnTollCollected(Vechile vechile, int tollAmount, int totalTollCollected)
        {
            throw new NotImplementedException();
        }
    }
}
