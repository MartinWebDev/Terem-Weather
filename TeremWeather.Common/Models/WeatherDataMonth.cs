namespace TeremWeather.Common.Models
{
    public class WeatherDataMonth : WeatherData
    {
        public Enums.Month Month { get; set; }
        public double MedianDailyRainfall { get; set; }
    }
}
