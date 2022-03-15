using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQBasics
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class CustomerAdress
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int CustomerId { get; set; }
    }
}
