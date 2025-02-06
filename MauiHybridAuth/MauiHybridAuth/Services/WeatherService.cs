using System.Net.Http.Json;
using MauiHybridAuth.Shared.Models;
using MauiHybridAuth.Shared.Services;

namespace MauiHybridAuth.Services;

public class WeatherService : IWeatherService
{
    private readonly HttpClient _client;

    public WeatherService(HttpClient client)
    {
        _client = client;
    }
    
    public async Task<IEnumerable<WeatherForecast>> GetWeatherForecasts()
    {
        var response = await _client.GetFromJsonAsync<IEnumerable<WeatherForecast>>("weatherforecast");
        return response ?? [];
    }
}