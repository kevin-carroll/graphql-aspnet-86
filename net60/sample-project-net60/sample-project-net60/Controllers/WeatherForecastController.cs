namespace sample_project_net60.Controllers
{
    using GraphQL.AspNet.Attributes;
    using GraphQL.AspNet.Controllers;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : GraphController
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"};


        [Query("weather")]
        public IEnumerable<WeatherForecast> RetrieveWeather()
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
}