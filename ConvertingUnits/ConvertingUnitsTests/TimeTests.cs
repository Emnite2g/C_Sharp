using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Converting_Units;
using Xunit;

namespace ConvertingUnitsTests
{
    public class TimeTests
    {
        [Theory]
        [InlineData(2400, 40)]
        [InlineData(156, 2.6)]
        [InlineData(1593.7, 26.56)]
        public void Devine60_ShouldCalculate(double x, double expected)
        {
            double actual = Time.Devine60(x);            

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4, 240)]
        [InlineData(143, 8580)]
        [InlineData(93.35, 5601)]
        public void Multiply60_ShouldCalculate(double x, double expected)
        {
            double actual = Time.Multiply60(x);            

            Assert.Equal(expected, actual);
        }
    }
}
