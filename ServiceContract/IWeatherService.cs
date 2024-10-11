//using DI_Assignment.Models;

using Models;

namespace ServiceContract
{
    public interface IWeatherService
    {
        List<CityWeather> GetWeatherDetails();
        CityWeather? GetWeatherByCityCode(string CityCode);

    }
}
