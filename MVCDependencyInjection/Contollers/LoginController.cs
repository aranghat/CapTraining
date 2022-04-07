using Microsoft.AspNetCore.Mvc;
using MVCCommon;

namespace MVCDependencyInjection.Contollers
{
    public class LoginController : Controller
    {
        ISmsSender smsSender;

        public LoginController(ISmsSender smsSender)
        {
            this.smsSender = smsSender;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
