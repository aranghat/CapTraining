using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public static class GlobalCarsSales
    {
        //Members inside a static class must also be static
        public static int GlobalCarsSold { get; private set; }
        public static void UpdateSaleCount()
        {
            GlobalCarsSold++;
        }
    }

    public class CarSales
    {
        public int TotalCarsSold { get; private set; }

        public void CarSold(string carName)
        {
            TotalCarsSold++;

            //Call to a static class does not need a instance
            GlobalCarsSales.UpdateSaleCount();
        }
    }
}
