using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods
{
    public class Account
    {
        public int AccountId      { get; set; }
        public string AccountType { get; set; }
        public string Name        { get; set; }
        public int CurrentBalance { get; private set; }

        //Having same Methods with diffrent signatures is called
        //Method overloading
        public int DepositAmount(int depositAmount)
        {
            CurrentBalance += depositAmount;
            return CurrentBalance;
        }

        public int DepositAmount(int depositAmount
                , string remarks)
        {
            CurrentBalance += depositAmount;
            Console.WriteLine($"Deposited Amount " +
                $":{depositAmount}, Remarks: {remarks}");
            return CurrentBalance;
        }

        public int DepositAmount(float depositAmount)
        {
            CurrentBalance += (int)depositAmount;
            return CurrentBalance;
        }

        public static bool operator ==
                    (Account firstAccount
                    , Account secondAccount)
        {
            bool isSame = firstAccount.AccountId == 
                                secondAccount.AccountId;
            return isSame;
        }

        public static bool operator !=(Account account1
            , Account account2)
        {
            bool isSame = account1.AccountId 
                                        == account2.AccountId;
            return isSame;
        }

        public static Account operator+(Account account1
                                       ,Account account2)
        {
            Account account = new Account();
            account.Name = account1.Name;
            account.CurrentBalance = account1.CurrentBalance 
                                        + account2.CurrentBalance;

            return account;
        }

    }
}
