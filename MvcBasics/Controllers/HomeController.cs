using Microsoft.AspNetCore.Mvc;

namespace MvcBasics.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View("~/Views/Home/AlternateView.cshtml");
            return View();
        }

        [Route("aboutus")]
        public IActionResult About()
        {
            return View();
        }

        [Route("contactus")]
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
