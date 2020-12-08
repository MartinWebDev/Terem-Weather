using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

using TeremWeather.Common.Models;
using TeremWeather.Common.Interfaces;

namespace TeremWeather.Data
{
    public class WeatherDataProviderFile : IWeatherDataProvider
    {
        private string file;

        public WeatherDataProviderFile(string filePath)
        {
            file = filePath;
        }
        // Has a method of reading data (file, db, completing a quest for the grand wizard) and returns it to the repo.
        // So the repo need not care how we get the data, it just cares about transforming it, in this case, aggregating it.

        // NOTE: I would have 1 small concern which would be that I am simply going to read and pass back all the data.
        // This will lead to slower speeds, and potential memory usage,
        // but have concluded that if you're going to throw a 100mb, expect it to take a while!
        // Actual data file is only about 2-2.5 MB though, so memory isn't really a concern in this project, and speed should be acceptable.
        public IEnumerable<WeatherDataRaw> GetData()
        {
            IEnumerable<WeatherDataRaw> lines = File.ReadAllLines(file).Skip(1).Select(x => ParseCsvLine(x));
            return lines;
        }

        private WeatherDataRaw ParseCsvLine(string line)
        {
            // Should pass in or somehow store a "column definition" variable to refer to, but for simplicity we'll just hard code the numbers here
            string[] values = line.Split(',');
            WeatherDataRaw row = new WeatherDataRaw();

            row.Year = Convert.ToInt32(values[2]);
            row.Month = Convert.ToInt32(values[3]);
            row.Day = Convert.ToInt32(values[4]);
            row.Rainfall = Convert.ToDouble(values[5]);
            
            return row;
        }
    }
}
