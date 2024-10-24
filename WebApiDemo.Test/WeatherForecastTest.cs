using Microsoft.Extensions.Logging;
using WebApiDemo.pub;
using WebApiDemo.pub.Controllers;

namespace WebApiDemo.Test
{
    public class WeatherForecastTest
    {
        private readonly ILogger<WeatherForecastController> _logger;


        [Fact]
        public void Get_AssertReturnAny()
        {
            // Arrange
            WeatherForecastController weatherForecast = new WeatherForecastController(_logger);

            // Act
            var result = weatherForecast.Get();

            // Arrange
            Assert.NotNull(result);

        }
    }
}