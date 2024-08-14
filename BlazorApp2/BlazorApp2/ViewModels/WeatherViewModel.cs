using BlazorApp2.Models;
using BlazorApp2.Repositories.Weather;

namespace BlazorApp2.ViewModels
{
    public class WeatherViewModel
    {
        IWeatherRepository weatherRepository;

        public WeatherViewModel(IWeatherRepository weatherRepository)
        {
            this.weatherRepository = weatherRepository;
        }

        public async Task<WeatherForecast[]?> GetWeather()
        {
            return await weatherRepository.GetWeather();
        }
    }
}
