using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibrary
{
    public class EmailProvider
    {
        private string servername;
        public EmailProvider(string servername)
        {
            this.servername = servername;
        }
        public string SentEmail(string to,string from,string body,string content)
        {
            Console.WriteLine($"Email has been sent to -> {to} from -> {from} through {servername}");
            return "Email Sent";
        }

        //public static void SentEmail(string to,string from)
        //{
        //    Console.WriteLine($"Email has been sent to -> {to} from -> {from}");
        //}

    }

    public class SmsProvider
    {

    }
}
