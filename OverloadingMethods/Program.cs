using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.Name = "Sreehari Aranghat";
            account.AccountId = 10001;
            account.AccountType = "Savings";

            account.DepositAmount(10000);
            account.DepositAmount(5000, "Intrest pay back");

            Console.WriteLine(account.CurrentBalance);

            Account account1    = new Account();
            account1.Name        = "Sreehari Aranghat";
            account1.AccountId   = 10001;
            account1.AccountType = "Savings";

            account1.DepositAmount(10000);
            account1.DepositAmount(5000, "Intrest pay back");

            if (account == account1)
                Console.WriteLine("Both are same account");
            else
                Console.WriteLine("Both are different Accounts");

            Account consolidatedAccount = account + account1;
            Console.WriteLine($"Total amount in bank " +
                $"{consolidatedAccount.CurrentBalance}");

        }
    }
}
