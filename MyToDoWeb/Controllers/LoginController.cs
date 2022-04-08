using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MyToDo;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyToDoWeb.Controllers
{
    [Route("/login")]
    public class LoginController : Controller
    {
        ToDoDbContext context;

        public LoginController(ToDoDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(User user)
        {
            var u = context.Users.FirstOrDefault(d => d.Email == user.Email
            && d.Password == user.Password);

            if (u != null)
            {
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.NameIdentifier, u.Id.ToString()));
                claims.Add(new Claim(ClaimTypes.Name, u.Email));
                //claims.Add(new Claim(ClaimTypes.Role, u.Role));

                var identity = new ClaimsIdentity(claims
                    , CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme
                    , new ClaimsPrincipal(identity));

                Response.Redirect("/");
            }
            else
            {
                ViewBag.Error = "Login Failed";
            }

            return View();
        }
    }
}
