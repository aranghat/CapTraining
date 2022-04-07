using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCModelBasics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace MVCModelBasics.Controllers
{
    [Route("/")]
    [Authorize]
    public class HomeController : Controller
    {
        static List<Book> books = new List<Book>();

        IHostingEnvironment hostingEnvironment;
        //STEP 3 : OPTIONAL Inject IHostingEnvironment
        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;

            if (books.Count == 0)
            {
                books.Add(new Book { Author = "Dan Brown", Id = 10001, Title = "Davinci Code", CoverImage = "1.jpg" });
                books.Add(new Book { Author = "Dan Brown", Id = 10002, Title = "Angels and Demons", CoverImage = "2.jpg" });
                books.Add(new Book { Author = "JK Rowling", Id = 10003, Title = "Harry Potter", CoverImage = "3.jpg" });
                books.Add(new Book { Author = "Robin Sharma", Id = 10004, Title = "Monk who sold his ferrari", CoverImage = "4.jpg" });
            }
        }

        #region others
        public IActionResult Index()
        { 
          var userId = HttpContext.User
                .Claims
                .FirstOrDefault(d => d.Type == 
                ClaimTypes.NameIdentifier).Value;
          ViewBag.UserId = userId;

            return View(books);
        }

        [Route("addnewbook")]
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateNewBook()
        {  
            return View();
        }

        #endregion
        [Route("addnewbook")]
        [HttpPost]
        public IActionResult CreateNewBook(Book book,IFormFile imgCover
                    /*STEP 4: Use IFormFile as parameter */)
        {
            if (ModelState.IsValid)
            {
                if (book != null)
                {
                    if (!books.Contains(book))
                    {
                        //STEP : 5 CHECK AND SAVE THE FILE
                        //Check if a file is uploaded
                        if(imgCover != null)
                        {
                            //Get the wwwroot path of the application
                            string wwwRootPath  = this.hostingEnvironment.WebRootPath;

                            //Create a unique file name
                            string fileName     = Guid.NewGuid().ToString() + ".jpg";

                            //Create a file
                            using (var stream = System.IO.File.Create(wwwRootPath
                                + @"\images\" + fileName))
                            {
                                //Copy the image to the file path
                                imgCover.CopyTo(stream);

                                //Set the book cover with the new file name
                                book.CoverImage = fileName;
                            }
                        }


                        books.Add(book);
                        Response.Redirect("/");
                    }
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
