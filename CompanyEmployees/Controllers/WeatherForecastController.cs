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
            _logger.LogInfo("H�r �r en Info log fr�n kontrollern");
            _logger.LogDebug("H�r �r en Debug log fr�n kontrollern");
            _logger.LogWarn("H�r �r en Warn log fr�n kontrollern");
            _logger.LogError("H�r �r en Error log fr�n kontrollern");

            return new string[] { "V�rde 1", "V�rde 2" };
        }
    }
}