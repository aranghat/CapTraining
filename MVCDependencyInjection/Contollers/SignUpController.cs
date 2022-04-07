using Microsoft.AspNetCore.Mvc;
using MVCCommon;

namespace MVCDependencyInjection.Contollers
{
    public class SignUpController : Controller
    {
        ISmsSender smsSender;

        public SignUpController(ISmsSender smsSender)
        {
            this.smsSender = smsSender;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
