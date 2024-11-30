using Microsoft.AspNetCore.Mvc;
using ReceiptApi.Models;

namespace ReceiptApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ReceiptController : ControllerBase
{

    public ReceiptController(Logger<ReceiptController> logger) => _logger = logger;
    [Route("api/receipts/{id}/points")]
    [HttpGet(Name = "GetReceipts")]
    [ProducesResponseType<ResponseReceiptViewModel>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400)]
    public IHttpActionResult GetReceipts(){
        return "hello world";
    }
//     private static readonly string[] Summaries = new[]
//     {
//         "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//     };

//     private readonly ILogger<WeatherForecastController> _logger;

//     public WeatherForecastController(ILogger<WeatherForecastController> logger)
//     {
//         _logger = logger;
//     }

//     [HttpGet(Name = "GetWeatherForecast")]
//     public IEnumerable<WeatherForecast> Get()
//     {
//         return Enumerable.Range(1, 5).Select(index => new WeatherForecast
//         {
//             Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//             TemperatureC = Random.Shared.Next(-20, 55),
//             Summary = Summaries[Random.Shared.Next(Summaries.Length)]
//         })
//         .ToArray();
//     }
}
