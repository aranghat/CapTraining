using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInCSharp
{
    public enum BookCategory
    {
        Crime,
        Novel
    }

    public class Book
    {
        //Auto implemented properties
        public BookCategory Category { get; set; }
        
        //The access of the property must be more than
        //that of the get or set
        public int Id { get; private set; }

        private string title;//Backing field

        public string remarks = "Rare collection";
        //Readonly Property
        public string Remarks
        {
            get
            {
                return remarks;
            }
        }

        public string Title //Property
        {
            get
            {
                return title;
            }
            set
            {
                if (value.Length > 0)
                    this.title = value;
                else
                    throw new Exception("Title cannot be blank");
            }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set
            {
                if (value.Length > 0)
                    this.author = value;
                else
                    throw new Exception("Author name cannot be blank");
            }
        }

        public Book()
        {
            Id = new Random().Next(100, 9999);
        }

        #region oldcode
        //public void setTitle(string title)
        //{
        //    if (title.Length > 0)
        //        this.title = title;
        //    else
        //        throw new Exception("Title cannot be blank");
        //}

        //public string getTitle()
        //{
        //    return this.title;
        //}

        //public void setAuthor(string author)
        //{
        //    if (author.Length > 0)
        //        this.author = author;
        //    else
        //        throw new Exception("Author name cannot be blank");
        //}

        //public string getAuthor()
        //{
        //    return this.author;
        //}
        #endregion
    }
}
