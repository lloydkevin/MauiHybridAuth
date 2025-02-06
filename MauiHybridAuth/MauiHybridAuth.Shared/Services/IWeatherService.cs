using MauiHybridAuth.Shared.Models;

namespace MauiHybridAuth.Shared.Services;

public interface IWeatherService
{
    public Task<IEnumerable<WeatherForecast>> GetWeatherForecasts();
}