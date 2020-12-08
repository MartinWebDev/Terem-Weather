using System;
using System.Collections.Generic;
using System.Text;

namespace TeremWeather.Common.Models
{
    public class WeatherDataRaw
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public double Rainfall { get; set; }
    }
}
