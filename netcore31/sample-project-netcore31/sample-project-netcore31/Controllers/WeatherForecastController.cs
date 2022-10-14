using GraphQL.AspNet.Attributes;
using GraphQL.AspNet.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace sample_project_netcoreapp31.Controllers
{
    public class WeatherForecastController : GraphController
    {
        private static Random _random = new Random();

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"};

        [Query("weather")]
        public IEnumerable<WeatherForecast> RetrieveWeather()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = _random.Next(-20, 55),
                Summary = Summaries[_random.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}