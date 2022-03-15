using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQBasics2
{
    public class Product
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public float UnitPrice { get; set; }
    }

    public class Customer
    {
        public long CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{CustomerId} / {Name} / {Email}";
        }
    }

    public enum OrderStatus
    {
        PENDING = 1
        , ONPROGRESS
        , OURFORDELIEVERY
        , DELIVERED
    }

    public class Order
    {
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public long CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
