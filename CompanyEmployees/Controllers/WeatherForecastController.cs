using Contracts;

using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        private readonly ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Här är en Info log från kontrollern");
            _logger.LogDebug("Här är en Debug log från kontrollern");
            _logger.LogWarn("Här är en Warn log från kontrollern");
            _logger.LogError("Här är en Error log från kontrollern");

            return new string[] { "Värde 1", "Värde 2" };
        }
    }
}