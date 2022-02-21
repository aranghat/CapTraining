using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeekDays weekdays = new WeekDays();
            string weekDay    = weekdays[0];
            int weekDayIndex = weekdays["Monday"];

            weekdays[0] = "MONDAY";

            //string weekDay = weekdays.GetWeekDayByIndex(0);
            Console.WriteLine(weekDay);
            Console.WriteLine(weekDayIndex);

        }
    }
}
