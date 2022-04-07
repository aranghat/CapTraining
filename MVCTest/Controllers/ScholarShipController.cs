using Microsoft.AspNetCore.Mvc;

namespace MVCTest.Controllers
{
    [Route("student/scholarship")]
    public class ScholarShipController : Controller
    {
        [Route("apply")]
        public IActionResult Index(int studentid)
        {
            return View();
        }
    }
}
