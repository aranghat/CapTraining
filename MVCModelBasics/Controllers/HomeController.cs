using Microsoft.AspNetCore.Mvc;
using MVCModelBasics.Model;
using System.Collections.Generic;
using System.Linq;

namespace MVCModelBasics.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        static List<Book> books = new List<Book>();

        public HomeController()
        {
            if (books.Count == 0)
            {
                books.Add(new Book { Author = "Dan Brown", Id = 10001, Title = "Davinci Code", CoverImage = "1.jpg" });
                books.Add(new Book { Author = "Dan Brown", Id = 10002, Title = "Angels and Demons", CoverImage = "2.jpg" });
                books.Add(new Book { Author = "JK Rowling", Id = 10003, Title = "Harry Potter", CoverImage = "3.jpg" });
                books.Add(new Book { Author = "Robin Sharma", Id = 10004, Title = "Monk who sold his ferrari", CoverImage = "4.jpg" });
            }
        }

        public IActionResult Index()
        {
            return View(books);
        }

        [Route("addnewbook")]
        [HttpGet]
        public IActionResult CreateNewBook()
        {  
            return View();
        }

        [Route("addnewbook")]
        [HttpPost]
        public IActionResult CreateNewBook(Book book)
        {
            if (ModelState.IsValid)
            {
                if (book != null)
                {
                    if (!books.Contains(book))
                        books.Add(book);
                    else
                        ViewBag.Error = $"{book.Title} already exist";
                }
            }
            else
            {
                ViewBag.IsValid = false;
            }

            return View();
        }

        [Route("updatebook/{bookid}")]
        [HttpGet]
        public IActionResult UpdateBook(int bookid)
        {
            Book book = books.FirstOrDefault(d => d.Id == bookid);
            return View(book);
        }

        [Route("updatebook")]
        [HttpPost]
        public IActionResult UpdateBook(Book book)
        {
            Book b = books.FirstOrDefault(d => d.Id == book.Id);

            if (b != null)
            {
                b.Author = book.Author;
                b.Title = book.Title;

                ViewBag.IsSuccessful = true;
                ViewBag.Message = "Book Updated Successfully";
            }
            else
            {
                ViewBag.IsSuccessful = false;
                ViewBag.Message = "Book Could not be updated";
            }


            return View(book);
        }
    }
}
