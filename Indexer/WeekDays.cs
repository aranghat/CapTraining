using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class WeekDays
    {
        string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        //Indexer
        //Special Property that will have a "this"
        //insted of a property name

        //Pro vs Indexer
        //1. Property can have a name, Indexer takes this
        //2. Property cannot have a parameter, Indexer can have one or more param
        public string this[int index]
        {
            get
            {
                return weekDays[index];
            }
             set
            {
                weekDays[index] = value;
            }
        }

        public int this[string weekDay]
        {
            get
            {
                int weekDayIndex = 0;
                for (int i = 0; i < weekDays.Length; i++)
                    if (weekDay.Equals(weekDays[i], StringComparison.OrdinalIgnoreCase))
                        weekDayIndex = i;

                return weekDayIndex;
            }
        }

        //public string GetWeekDayByIndex(int index)
        //{
        //    return weekDays[index];
        //}
    }
}
