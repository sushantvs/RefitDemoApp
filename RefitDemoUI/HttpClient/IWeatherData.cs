using Refit;
using RefitDemoUI.Models;

namespace RefitDemoUI.HttpClient
{
    public interface IWeatherData
    {
        [Get("/WeatherForecast")]
        Task<List<WeatherModel>> GetWeatherAsync();
    }
}
