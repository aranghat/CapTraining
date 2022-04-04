using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiAuth.Model;
using System.Linq;

namespace WebApiAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class WeatherController : ControllerBase
    {
        static List<WeatherReport> weelyWether = new List<WeatherReport>();

        public WeatherController()
        {
            if (weelyWether.Count == 0)
            {
                weelyWether.Add(new WeatherReport { WeekDay = "Sunday", Temprature = 32.0F });
                weelyWether.Add(new WeatherReport { WeekDay = "Monday", Temprature = 27.0F });
                weelyWether.Add(new WeatherReport { WeekDay = "Tuesday", Temprature = 31.0F });
                weelyWether.Add(new WeatherReport { WeekDay = "Wednesday", Temprature = 25.0F });
                weelyWether.Add(new WeatherReport { WeekDay = "Thursday", Temprature = 26.0F });
                weelyWether.Add(new WeatherReport { WeekDay = "Friday", Temprature = 28.0F });
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(weelyWether);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Put(WeatherReport report)
        {
            var weatherReport = weelyWether.FirstOrDefault(d => d.WeekDay == report.WeekDay);

            if (weatherReport != null)
            {
                weatherReport.Temprature = report.Temprature;
                return Ok(weatherReport);
            }
            else
                return NotFound($"No weather report found for {report.WeekDay}");
        }
    }
}
