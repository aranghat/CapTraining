using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyToDo;
using System.Linq;
using System.Security.Claims;

namespace MyToDoWeb.Controllers
{
    [Route("/")]
    [Authorize]
    public class HomeController : Controller
    {
        ToDoDbContext context = new ToDoDbContext();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.MyToDoItems = context.ToDoItems;
            return View();
        }

        [HttpPost]
        public IActionResult Index(ToDoItem item)
        {
            if(ModelState.IsValid)
            {
                item.User = GetCurrentUser();

                context.ToDoItems.Add(item);
                context.SaveChanges();
            }

            ViewBag.MyToDoItems = context.ToDoItems;

            return View();
        }

        [HttpPost]
        [Route("markascompleted/{id}")]
        public IActionResult MarkAsCompleted(int id)
        {
            ToDoItem toDoItem = context.ToDoItems.FirstOrDefault(d => d.Id == id);
            toDoItem.IsCompleted = true;

            context.SaveChanges();

            Response.Redirect("/");

            return View();
        }

            User GetCurrentUser()
        {
            var userId = HttpContext.User
                .Claims
                .FirstOrDefault(d => d.Type ==
                ClaimTypes.NameIdentifier).Value;

            User user = context.Users.FirstOrDefault(u => u.Id == int.Parse(userId));
            return user;
        }
    }
}
