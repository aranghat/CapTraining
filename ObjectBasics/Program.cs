using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region oldcode
            //Book book1       = new Book();
            //book1.title      = "Angels and Demons";
            //book1.author     = "Dan Brown";
            //book1.isbnnumber = "ABC1234";
            //book1.id         = 1000;

            //book1.DisplayDetails();



            //Book book2       = new Book
            //{
            //    author = "JK Rowling",
            //    title = "Harry Potter",
            //    isbnnumber = "ABC1234"
            //};

            //book2.DisplayDetails();


            //Book book3       = new Book("Angels and Demons"
            //                           ,"Dan Brown"
            //                           ,"XYZ1235");


            //book3.DisplayDetails();

            //Console.ReadLine();
            #endregion

            Book [] books = new Book[2];//Declaring an Array of books

            for(int i = 0;i< 2; i++)
            {
                var b = new Book();

                Console.Write("ID :");
                string userInput = Console.ReadLine();
                b.id        = int.Parse(userInput);

                Console.Write("Title :");
                b.title     = Console.ReadLine();

                Console.Write("Author : ");
                b.author    = Console.ReadLine();

                Console.Write("ISBN : ");
                b.isbnnumber = Console.ReadLine();

                Console.WriteLine("Category :");
                Console.WriteLine(String.Join("\n\t->",Enum.GetNames(typeof(BookCategory))));

                Console.Write("Enter your choice :");
                string userInputCategogy = Console.ReadLine();

                //int.Parse(userInputCategogy);
               // b.category = (BookCategory)Enum.Parse(typeof(BookCategory)
                                             // , userInputCategogy);

                if(!Enum.TryParse<BookCategory>(userInputCategogy,out b.category))
                    Console.WriteLine("Invalid book category");
               
                if (IsUnique(b.id, books))
                {
                    books[i] = b;
                }
                else
                {
                    Console.WriteLine($"Book Id : {b.id} is already used");
                    i = i - 1;
                }
            }


            foreach (var book in books)
                if(book != null)
                     book.DisplayDetails();
        }

        static bool IsUnique(int id,Book [] books)
        {
            bool isUnique = true;

            foreach(Book book in books)
            {
                if (book != null)
                {
                    if (book.id == id)
                    {
                        isUnique = false;
                        break;
                    }
                }
            }

            return isUnique;
        }
    }

}
