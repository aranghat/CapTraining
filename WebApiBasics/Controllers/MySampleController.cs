using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiBasics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MySampleController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("Time in the server is " + DateTime.Now);
        }
    }
}
