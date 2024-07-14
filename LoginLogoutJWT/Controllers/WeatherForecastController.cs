using LoginLogoutJWT.DatabaseContext;
using LoginLogoutJWT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace LoginLogoutJWT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly UserDbContext _dbb;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,UserDbContext db)
        {
            _logger = logger;
            _dbb = db;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}


        //[HttpGet(Name = "GetUser")]
        [HttpGet]
        [Route("GetUser")]
        public IEnumerable<Users> GetN()
        {
           return _dbb.Users.ToList();
        }

        //[HttpGet(Name = "GetUserInfo")]
        [HttpGet]
        [Route("GetJ")]
        public List<string> GetJ()
        {
           
            List<string> list = new List<string>();
            list.Add("fkmd");
            return list;
        }

    }
}