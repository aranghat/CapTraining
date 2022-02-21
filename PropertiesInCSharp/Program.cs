using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book       = new Book();
            book.Title      = "Angels and Demons";
            book.Author     = "Dan Brown";
            book.Category   = BookCategory.Crime;
        

           Console.WriteLine(book.Title);  
           Console.WriteLine(book.Author);
           Console.WriteLine(book.Remarks);
           Console.WriteLine(book.Id);
        }
    }
}
