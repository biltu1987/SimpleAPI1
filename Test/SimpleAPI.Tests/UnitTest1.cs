using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        WeatherForecastController obj;
        [Fact]
        public void GetReturnValue()
        {
            obj = new WeatherForecastController();
            var _result = obj.Get(1);
            Assert.Equal("Biltu Khawas1",_result.Value);
        }
    }
}
