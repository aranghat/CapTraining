using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visa;


namespace NameSpaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MasterCard.CreditCardValidaor masterCardValidator = new MasterCard.CreditCardValidaor();
            //masterCardValidator.ValidateCreditCard();

            //Visa.CreditCardValidaor visaCardValidator = new Visa.CreditCardValidaor();
            //visaCardValidator.ValidateCreditCard();

            CreditCardValidaor creditCardValidaor 
                = new CreditCardValidaor();
            creditCardValidaor.ValidateCreditCard();
        }
    }
}
