using Microsoft.AspNetCore.Mvc;

namespace MVCTest.Controllers
{
    [Route("/students")]
    public class StudentController : Controller
    {
        [Route("list")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("addstudent")]
        public IActionResult AddStudent(object stuent)
        {
            return View();
        }

        
    }
}
