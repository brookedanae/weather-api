using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WeatherAPI.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _client;

        public WeatherService(HttpClient client)
        {
            _client = client;
        }

        public async Task<WeatherResponse> QueryWeatherAsync(string name)
        {
            return await _client.GetFromJsonAsync<WeatherResponse>($"{name}/openapi.json");
        }
    }
}
