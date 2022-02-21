using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            //Defined in Account.cs
            account.Name = "Sreehari Aranghat";

            //Defined in AdditionalAccountDetails.cs
            account.MinBalance = 10000;
        }
    }
}
