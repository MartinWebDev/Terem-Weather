using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

using TeremWeather.Common.Models;
using TeremWeather.Data;

namespace TeremWeather.Data.Tests
{
    [TestClass]
    public class WeatherDataProviderFileUnitTests
    {
        [TestMethod]
        public void CanReadBasicFile()
        {
            WeatherDataProviderFile weatherDataProvider = new WeatherDataProviderFile("InputFiles/Sample1.csv");
            var data = weatherDataProvider.GetData().ToList();

            var line2expected = new WeatherDataRaw() { Year = 2000, Month = 1, Day = 2, Rainfall = 4.2 };
            var line4expected = new WeatherDataRaw() { Year = 2000, Month = 1, Day = 4, Rainfall = 0.0 };

            // Test a random sample of expected values to know if file has been read correctly.
            // Day
            Assert.AreEqual(line2expected.Day, data[1].Day);
            Assert.AreEqual(line4expected.Day, data[3].Day);
            // Rainfall
            Assert.AreEqual(line2expected.Rainfall, data[1].Rainfall);
            Assert.AreEqual(line4expected.Rainfall, data[3].Rainfall);
        }
    }
}
