using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string strData        = "Hello World,\n This is such a \nwonderful\tday!!!\n\n";
            ////string myFilePath       = "c:\\training\\program.cs";
            //string stringWithQuotes = "A wise man once said \"bla bla bla\"";
            //string myFilePath       = @"c:\training\n\program.cs";

            string paragragh = 
@"The news today says there is a rare chance of rain
by evening as per the 
latest weather report";

            //Console.WriteLine(strData);

            //Console.WriteLine(myFilePath);
            //Console.WriteLine(stringWithQuotes);

            //Console.WriteLine(paragragh);

            char[] names = { 'V', 'B', 'G', 'O', 'R' };
            string strName = new string(names);

            //Console.WriteLine(strName);

           
            //char[] charFromString = strMessage.ToCharArray(); 

           

            ///Console.WriteLine(charFromString.Length);

            //foreach (char c in charFromString)
            //    Console.WriteLine(c);

            //for (int i = 0; i < charFromString.Length; i++)
            //    Console.WriteLine(charFromString[i]);

            string str1 = @"c:\program files\microsoft.net";
            string str2 = @"C:\PROGRAM FILES\microsoft.net";

            //if(str1.Equals(str2,StringComparison.OrdinalIgnoreCase)) //if (str1 == str2)
            //{
            //    Console.WriteLine("Both are same string");
            //}
            //else
            //    Console.WriteLine("Both are diffrent");

            string strMessage = "Hello There; What a wonderful world, and a wonderful day";

            //Console.WriteLine(strMessage.ToUpper());
            //Console.WriteLine(strMessage.ToLower());

            //if (strMessage.ToLower().Contains("our"))
            //    Console.WriteLine("The word has 'our'");
            //else
            //    Console.WriteLine("The word does not contain 'our'");

            //Console.WriteLine(strMessage.IndexOf("wonderful"));
            //Console.WriteLine(strMessage.LastIndexOf("wonderful"));

            int indexOfWord = strMessage.LastIndexOf("wonderful");

            //Console.WriteLine(strMessage.Insert(indexOfWord, "This is a new sentance"));
            //Console.WriteLine(strMessage.Replace("wonderful", "beautiful"));

            int indexOfIs = strMessage.IndexOf("is");

            //Console.WriteLine(strMessage.Remove(indexOfIs,5));

            //Console.WriteLine(strMessage.Substring(12));
            //Console.WriteLine(strMessage.Substring(12, 6));

            //string [] splittedItems = strMessage.Split(',');
            //foreach(string item in splittedItems)
            //    Console.WriteLine(item);

            //char[] splititems        = { ';', ',' };
            //string[] splittedItems2  = strMessage.Split(splititems);

            //foreach (string item in splittedItems2)
            //    Console.WriteLine(item);

            //string str = "Hello";
            //str += " World";
            //str += ", Such a wonderful day";

            
            StringBuilder builder = new StringBuilder();
            string userInput      = string.Empty;

            do
            {
                userInput = Console.ReadLine();

                if(!userInput.Equals("Exit",StringComparison.OrdinalIgnoreCase))
                    builder.Append($"{userInput} ");
            }
            while (!userInput.Equals("Exit",StringComparison.OrdinalIgnoreCase));


            Console.WriteLine(builder);

        }
    }
}
