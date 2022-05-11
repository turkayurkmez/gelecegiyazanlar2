using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;

namespace CacheMechanisms.Controllers
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
        private readonly IMemoryCache cache;
        private readonly IDistributedCache distributedCache;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMemoryCache cache, IDistributedCache distributedCache)
        {
            _logger = logger;
            this.cache = cache;
            this.distributedCache = distributedCache;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {


            var isInCache = cache.TryGetValue("WeatherForecast", out WeatherForecast[] cachedForecasts);
            if (!isInCache)
            {
                var forecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                    CreatedDate = DateTime.Now
                }).ToArray();


                cachedForecasts = forecasts;
                cache.Set("WeatherForecast", forecasts, new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddMinutes(5)

                });
            }

            cache.GetOrCreate("alternative", entry =>
            {
                entry.SlidingExpiration = TimeSpan.FromMinutes(5);
                return new[] { "A", "B", "C" };
            });




            return Ok(cachedForecasts);
        }


        [HttpGet("[action]")]
        public IActionResult GetCache()
        {
            return Ok(cache.Get("WeatherForecast"));
        }

        [HttpGet("[action]")]
        public IActionResult GetDistributedCache()
        {
            return Ok(distributedCache.GetString("products"));
            
        }
    }
}