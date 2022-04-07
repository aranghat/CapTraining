using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MVCModelBasics.Controllers
{
    [Route("/login")]
    public class LoginController : Controller
    {
        List<User> users = new List<User>();

        public LoginController()
        {
            users.Add(new User { Id = 10001, Name = "Sree", UserName = "sreehariis@gmail.com", Password = "12345", Role = "User" });
            users.Add(new User { Id = 10002, Name = "Bill", UserName = "bill@gmail.com", Password = "12345", Role = "Admin" });
            users.Add(new User { Id = 10003, Name = "Steve", UserName = "steve@gmail.com", Password = "12345", Role = "User" });

        }

        [HttpGet]
        public IActionResult Index()
        {
          

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(User user)
        {
            var u = users.FirstOrDefault(d => d.UserName == user.UserName 
            && d.Password == user.Password);

            if (u != null)
            {
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.NameIdentifier, u.Id.ToString()));
                claims.Add(new Claim(ClaimTypes.Name, u.UserName));
                claims.Add(new Claim(ClaimTypes.Role, u.Role));

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
