using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarSales bangloreSales = new CarSales();
            CarSales mumbaiSales   = new CarSales();
            CarSales chenneiSales  = new CarSales();

            bangloreSales.CarSold("Swift");
            bangloreSales.CarSold("Beleno");
            bangloreSales.CarSold("Swift");
            bangloreSales.CarSold("Swift");
            bangloreSales.CarSold("Swift");

            mumbaiSales.CarSold("Swift");
            mumbaiSales.CarSold("Beleno");
            mumbaiSales.CarSold("Swift");

            chenneiSales.CarSold("Beleno");


            Console.WriteLine($"Total Cars Sold : {bangloreSales.TotalCarsSold}");
            Console.WriteLine($"Total Cars Sold : {mumbaiSales.TotalCarsSold}");
            Console.WriteLine($"Total Cars Sold : {chenneiSales.TotalCarsSold}");

            Console.WriteLine($"Total Cars : {GlobalCarsSales.GlobalCarsSold}");
        }
    }
}
