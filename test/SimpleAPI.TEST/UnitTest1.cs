using Xunit;
using System;
using SimpleAPI.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace SimpleAPI.TEST
{

    public class UnitTest1
    {
       
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void Test1()
        {
            IEnumerable<WeatherForecast> retval = controller.Get();
            Assert.Equal(5, (int) retval.Count());
        }
    }
}
