using System;
using System.Collections.Generic;
using System.Text;

using TeremWeather.Common.Models;
using TeremWeather.Common.Interfaces;

namespace TeremWeather.Data
{
    public class WeatherDataProviderDB : IWeatherDataProvider
    {
        // This is where a database version would be, just to demo the dependancy inversion aspect of this mini project
        public IEnumerable<WeatherDataRaw> GetData()
        {
            throw new NotImplementedException();
        }
    }
}
