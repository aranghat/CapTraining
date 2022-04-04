using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBasics.Model;

namespace WebApiBasics.Controllers
{
    [Route("api/weather")]
    [ApiController]
    public class WeatherReportController : ControllerBase
    {
        static List<WeatherReport> weelyWether = new List<WeatherReport>();

        public WeatherReportController()
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

        //Actions
        public IActionResult Get()
        {
            var todayReport = new WeatherReport { WeekDay = DateTime.Now.DayOfWeek.ToString()
                                                , Temprature = 32.0F };
            return Ok(todayReport);
        }

        [Route("fortheweek")]
        public IActionResult GetWeatherForWeek()
        {
            return Ok(weelyWether);
        }

        [Route("fortheweek/{weekday}")]
        public IActionResult GetWeatherForWeekDay(string weekday)
        {
            if (string.IsNullOrEmpty(weekday) || weekday.Length < 4)
                return BadRequest("Weekday is empty or invalid");

            var weatherReport = weelyWether.FirstOrDefault(d => d.WeekDay == weekday);

            if (weatherReport != null)
                return Ok(weatherReport);
            else
                return NotFound($"No weather report was found for {weekday}");
        }

        [HttpPost]
        public IActionResult Post(WeatherReport report)
        {
            weelyWether.Add(report);
            return Ok(weelyWether);
        }

        [HttpPut]
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

        [HttpDelete("{weekday}")]
        public IActionResult Delete(string weekday)
        {
            var weatherReport = weelyWether.FirstOrDefault(d => d.WeekDay == weekday);

            if (weatherReport != null)
            {
                weelyWether.Remove(weatherReport);
                return Ok(weelyWether);
            }
            else
                return NotFound($"No weather report found for {weekday}");
        }
    }
}
