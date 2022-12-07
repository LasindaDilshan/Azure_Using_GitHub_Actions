using Microsoft.AspNetCore.Mvc;

namespace Azure_Using_GitHub_Actions.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;


        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<String> Get()
        {
           
            yield return "Azure_Deployement_Using_GitHub_Actions";
        }
    }
}