using System.Collections.Generic;

namespace TeremWeather.Common.Models
{
    public class WeatherDataYear : WeatherData
    {
        // Could probably stand to make this a smaller data type, I can't imagine this aweesome product will still be in use in 2 billion years :P
        public int Year { get; set; }
        public int LongestNumberOfDaysRaining { get; set; }
        public IEnumerable<WeatherDataMonth> MonthlyAggregates { get; set; }
    }
}
