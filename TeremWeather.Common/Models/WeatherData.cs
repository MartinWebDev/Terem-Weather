using System;
using System.Collections.Generic;
using System.Text;

namespace TeremWeather.Common.Models
{
    public abstract class WeatherData
    {
        // Common between month and year, so DRY
        public DateTime FirstRecordedDate { get; set; }
        public DateTime LastRecordedDate { get; set; }
        public double AverageDailyRainfall { get; set; }
        public double TotalRainfall { get; set; }
        public int DaysWithNoRainfall { get; set; }
        public int DaysWithRainfall { get; set; }
    }
}
