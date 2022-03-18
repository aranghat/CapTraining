using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloEfCore.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set;}
        public float TotalAvailableQuantity { get; set; }
        public float UnitPrice { get; set; }

        public Product() { }

        public Product(string name, float totalAvailableQuantity, float unitPrice)
        {
            Name = name;
            TotalAvailableQuantity = totalAvailableQuantity;
            UnitPrice = unitPrice;
        }
    }
}
