using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using WebApiAuth.Model;

namespace WebApiAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        List<User> users = new List<User>();

        public LoginController()
        {
            users.Add(new Model.User { Name = "Sree", UserName = "sreehariis@gmail.com", Password = "12345" });
            users.Add(new Model.User { Name = "Bill", UserName = "bill@gmail.com", Password = "12345" });
            users.Add(new Model.User { Name = "Steve", UserName = "steve@gmail.com", Password = "12345" });
        }

        [HttpPost]
        public IActionResult Post(User user)
        {
            var u = users.FirstOrDefault(d => d.UserName == user.UserName && d.Password == user.Password);

            if (u != null)
            {
                var jwtToken = GenerateToken(u.UserName);
                return Ok(jwtToken);
            }
            else
                return Unauthorized("Login Failed");
        }

        private string GenerateToken(string userName)
        {
            string jwtToken = string.Empty;

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Some Secret"));
            var credentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);

            var token  = new JwtSecurityToken("myapp.com"
                                            , "myapp.com"
                                            ,null
                                            ,expires: DateTime.Now.AddDays(7)
                                            ,signingCredentials: credentials);


            jwtToken = new JwtSecurityTokenHandler().WriteToken(token);

            return jwtToken;
        }
    }
}
