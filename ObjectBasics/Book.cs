using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBasics
{
    public enum BookCategory
    {
        Comics
        ,Thriller
        ,Crime
        ,Fiction
        ,ChildrensComics
    }

    public class Book
    {
        public int id;
        public string title;
        public string author;
        public string isbnnumber;

        public BookCategory category;

        //Default Constructor 
        public Book()
        {
            Console.WriteLine("Creating new object");
            id = new Random().Next(100, 999);
        }

        //Parameratized Constructor
        public Book(string t
                    ,string author
                    ,string isbnnumber) : this()
        {
            title           = t;
            this.author     = author;
            this.isbnnumber = isbnnumber;
        }

        //1. It does not have return type
        //2. It cannot have parameters
        //3. It cannot be invoked from code
        //4. No control over when it will be called
        ~Book()
        {
            Console.WriteLine("Object is destroyed");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($@"Id : {id}
                                Title : {title}
                                Author : {author}
                                ISBN : {isbnnumber}
                                CATE : {category}
                                ");
        }
    }
}
