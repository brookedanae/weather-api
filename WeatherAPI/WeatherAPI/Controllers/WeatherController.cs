using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherAPI.Models;
using WeatherAPI.Services;

namespace WeatherAPI.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherService _service;

        public WeatherController(IWeatherService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var response = await _service.QueryWeatherAsync("openapi");
            var model = response.data.children.Select(x => new WeatherViewModel(x.data.longitude, x.data.latitude));
            return View(response);
        }
    }
}
