using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MVCModelBasics.Controllers
{
    [Route("/config")]
    public class ConfigReaderController : Controller
    {
        IConfiguration configuration;

        public ConfigReaderController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            var clientName = configuration.GetValue<string>("ClientInformation:ClientName");
            var dataBaseInfo = configuration.GetValue<string>("ClientInformation:DatabaseServerInfo");

            ViewBag.ClientName = clientName;
            ViewBag.DataBaseInfo = dataBaseInfo;

            return View();
        }
    }
}
