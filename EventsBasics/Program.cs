using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodOrder order     = new FoodOrder();
            order.Id            = 1001;
            order.OrderDetails  = "Double Patty Veg Burger";

            //Subscribing for the event
            order.OrderReady += Order_OrderReady;
            order.OrderReady += Order_Shipped;
            order.ProcessOrder();

            Console.ReadLine();
        }

        private static void Order_Shipped(string orderDetails)
        {
            Console.WriteLine($"{orderDetails} is shipped with the delivery partner");
        }

        //Event Handler
        private static void Order_OrderReady(string orderDetails)
        {
            Console.WriteLine(orderDetails + " is ready");
        }
    }
}
