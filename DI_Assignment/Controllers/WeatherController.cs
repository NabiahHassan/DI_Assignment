using Microsoft.AspNetCore.Mvc;
using ServiceContract;

namespace DI_Assignment.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherService _weatherService;
        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }
      

        [Route("/")]
        public IActionResult Index()
        {
            var cities = _weatherService.GetWeatherDetails();
            return View(cities);
        }
        [Route("/weather/{citycode?}")]
        public IActionResult City(string? citycode)
        { 
            if (citycode == null)
            {
                return View();
            }
            var city = _weatherService.GetWeatherByCityCode(citycode);
            return View(city);
           
        }
    }
}
