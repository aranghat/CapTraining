using AirtelSmsLibrary;
using Microsoft.AspNetCore.Mvc;
using MVCCommon;

namespace MVCDependencyInjection.Contollers
{
    [Route("/")]
    public class HomeController : Controller
    {
        ISmsSender smsSender;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string sms)
        {

            ViewBag.Message = smsSender.SentSMS(9945747395, sms);
            return View();
        }

        
    }
}
