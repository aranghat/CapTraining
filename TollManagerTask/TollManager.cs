using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TollManagerTask
{
    public class TollManager
    {
        private int totalTollCollected = 0;

        public delegate void TollCollectionCompleted(Vechile vechile,int tollAmount,int totalTollCollected);
        public event TollCollectionCompleted OnTollCollected;

        public void CollectToll(Vechile vechile)
        {
            int tollAmount = 0;
            switch(vechile.VechileType)
            {
                case VechileType.FourWeeler : tollAmount = 50;break;
                case VechileType.Cargo      : tollAmount = 100; break;
            }

            totalTollCollected += tollAmount;

            Thread.Sleep(2000);

            if(OnTollCollected != null)
                OnTollCollected(vechile,tollAmount,totalTollCollected);
        }
    }

    public enum VechileType
    {
        TwoWeeler,
        FourWeeler,
        Cargo
    }

    public class Vechile
    {
        public string VechileNumber { get; set; }
        public VechileType VechileType { get; set; }
    }
}
