using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAPI.Models
{
    public class WeatherViewModel
    {
        public WeatherViewModel(string longitude, string latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public string Longitude { get; set; }

        public string Latitude { get; set; }
    }
}
