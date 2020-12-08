using System;
using System.Collections.Generic;
using System.Text;
using TeremWeather.Common.Models;

namespace TeremWeather.Common.Interfaces
{
    public interface IWeatherDataProvider
    {
        IEnumerable<WeatherDataRaw> GetData();
    }
}
