using BlazorApp2.Models;

namespace BlazorApp2.Repositories.Weather
{
    public interface IWeatherRepository
    {
        Task<WeatherForecast[]?> GetWeather();
    }
}
