using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsBasics
{
    public class FoodOrder
    {
        public delegate void OrderReadyEventHandler(string orderDetails);

        public event OrderReadyEventHandler OrderReady;

        public int Id { get; set; }
        public string OrderDetails  { get; set; }


        public void ProcessOrder()
        {
            Console.WriteLine("Starting to create Food");
            Thread.Sleep(3000);

            //Raise Event
            OrderReady(OrderDetails);
        }

        
    }
}
