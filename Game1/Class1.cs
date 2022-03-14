using GameShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    [GameAttribute("MOTO RACING","RACE THROUGH THE CITY STREETS")]
    public class RacingGame1 : IGameService
    {
        public void Play()
        {
            Console.WriteLine("Starting Racing Game 1");
        }
    }
}
