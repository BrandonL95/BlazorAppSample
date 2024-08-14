using BlazorApp2.Models;
using BlazorApp2.ViewModels;
using Microsoft.AspNetCore.Components;

namespace BlazorApp2.Components.Pages
{
    public partial class Weather : ComponentBase
    {
        [Inject]
        WeatherViewModel ViewModel { get; set; }

        [Parameter]
        public int? Number {  get; set; }

        private WeatherForecast[]? forecasts;

        protected override async Task OnInitializedAsync()
        {
            // Simulate asynchronous loading to demonstrate streaming rendering
            await Task.Delay(500);

            forecasts = await ViewModel.GetWeather();
        }
    }
}
