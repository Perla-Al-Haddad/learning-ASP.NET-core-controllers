/**
*   The base class: ControllerBase
*   A controller is a public class with one or more public methods knows as action. 
*   By convention, a controller is placed in the project root's Controllers directory.
*   The actions are exposed as HTTP endpoints via routing. So an HTTP GET request to https://localhost:{PORT}/weatherforcast cause the Get() method of the WeatherForecastController class to be executed
*   
*   The first thing to notice is that this class inherits from ControllerBase base class.
*   This base class provides a lot of standard functionality for handling HTTP requests, so you can focus on the specific business logic for your application.
*
*   If you have experience with Razor Pages or model-view-controller (MVC) architecture development in ASP.NET Core, you've used the Controller class. Don't create a web API controller by deriving from the Controller class. Controller derives from ControllerBase and adds support for views, so it's for handling webpages, not web API requests.
*/
using Microsoft.AspNetCore.Mvc;

namespace learning_ASP.NET_core_controllers.Controllers;

// [ApiController] enables opinionated behaviors that make it easier to build APIs. Some behaviors include parameter source inference, attribute routing as a requirements, and model validation error-handling enhancements
[ApiController]
// [Route] defines the routing pattern [controller]. The [controller] token is replaced by controller's name (case-insensitive, without the Controller suffix). This controller handles requests to https://localhost:{PORT}/weatherforecast. 
// The route might contain static strings, as in api/[controller]. In this example, this controller would handle a request to https://localhost:{PORT}/api/weatherforecast.
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
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
