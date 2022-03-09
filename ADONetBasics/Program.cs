using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Sreehari A";
            customer.Email = "sree@outlook.com";
            customer.Address = "Address 101";

            //Connection String
            string conStr = "Integrated Security=SSPI;Server=.;DataBase=ecom_temp";
          //string conStr = "Integrated Security=False;Server=.\SQLEXPRESS;DataBase=ecom_temp;uid=sa;password=pass@123";


        }
    }
}
