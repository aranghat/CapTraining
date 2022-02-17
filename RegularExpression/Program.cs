using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input     = "Sreehari";
            //string input     = "ABC123456789";
            //string input     = "9988112233";
            //string input     = "9988112233";
            string input       = "";

            //string pattern   = "^[a-zA-Z]*$";//Pattern which checks for only alphabets
            //string pattern   = "^[0-9]*$";//Checks if it has numbers between 0-9
            //string pattern   = "^[0-9a-zA-Z]*$";
            //string pattern   = "^[0-9]{10}$";
            //string pattern   = @"^[\d]{3,10}$";
            //string pattern    = @"^[A-Z]{3}-[\d]{3}$";
            //string pattern      = "^[A-Z]+$";
            //KA 04 AB 1234

            string sms = "Your OTP for login is 12345";

            var matches = Regex.Matches(sms, @"[\d]+");

            string delta = "XYZ";
            foreach (Match match in matches)
            {
                sms = sms.Replace(match.Value,match.Value + delta);
            }

            Console.WriteLine(sms);
            string replaceOtp = Regex.Replace(sms, @"[\d]{5}", "*****");
            Console.WriteLine(replaceOtp);

            //var isMatch      = Regex.IsMatch(input, pattern);

            //if (isMatch)
            //{
            //    Console.WriteLine("Matches the pattern");
            //}
            //else
            //    Console.WriteLine("Does not match");
        }
    }
}
