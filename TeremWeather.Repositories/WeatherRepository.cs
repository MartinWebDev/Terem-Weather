using System;
using System.Collections.Generic;
using System.Linq;
using TeremWeather.Common.Interfaces;
using TeremWeather.Common.Models;
using TeremWeather.Data;

namespace TeremWeather.Repositories
{
    public class WeatherRepository
    {
        private IWeatherDataProvider weatherDataProvider;

        // For this project, since I do not have an IoC container, I have decided to use an extraordinarily basic factory to act as my IOC :)
        public WeatherRepository()
        {
            weatherDataProvider = FakeIOCContainerFactory.CreateWeatherDataProvider();
        }

        // True IOC constuctor
        public WeatherRepository(IWeatherDataProvider provider)
        {
            weatherDataProvider = provider;
        }

        public IEnumerable<WeatherDataYear> GetAllAggregatedData()
        {
            IEnumerable<WeatherDataRaw> data = weatherDataProvider.GetData();
            // 1. Data will be a list
            // 2. Loop over
            //var model = data.ToList()
            //    .GroupBy(o => new
            //    {
            //        Month = o.Month,
            //        Year = o.Year
            //    })
            //    .Select(g => new WeatherDataYear
            //    {
            //        Month = g.Key.Month,
            //        Year = g.Key.Year,
            //        Total = g.Count()
            //    })
            //    .OrderByDescending(a => a.Year)
            //    .ThenByDescending(a => a.Month)
            //    .ToList();
            throw new NotImplementedException();
        }
    }
}
