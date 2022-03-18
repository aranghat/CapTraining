using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloEfCore.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }
        public Product  Product { get; set; }

        public int Quantity { get; set; }
        public float TotalPrice { get; set; }

        public string DeliveryStatus { get; set; }
    }
}
