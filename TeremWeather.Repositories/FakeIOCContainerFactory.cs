using System;
using System.Collections.Generic;
using System.Text;

using TeremWeather.Data;
using TeremWeather.Common.Interfaces;

namespace TeremWeather.Repositories
{
    public class FakeIOCContainerFactory
    {
        public static IWeatherDataProvider CreateWeatherDataProvider()
        {
            return new WeatherDataProviderFile("TODO: File!!");
        }
    }
}
