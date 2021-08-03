using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDebugServerApp.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        
        // TODO: Test debug Server Code
        /*
         * 1. Set a breakpoint on the 24 row
         * 2. Run debug 
         * 3. Browse to the Fetch Data page to hit the first breakpoint in the FetchData component just before it issues an HTTP request to the server.
         * 3. See how the server code shows the date of transition to this page (startDate)
         * 4. See weather forecast table rendered in the browser
         */
        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}