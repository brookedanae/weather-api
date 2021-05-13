using System.Threading.Tasks;

namespace WeatherAPI.Services
{
    public interface IWeatherService
    {
        Task<WeatherResponse> QueryWeatherAsync(string name);
    }
}