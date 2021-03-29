using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Converting_Units;

namespace ConvertingUnitsTests
{
    public class CelFahrTests
    {
        [Theory]
        [InlineData(45, 7.22)]
        [InlineData(23.5, -4.72)]
        [InlineData(39.5, 4.17)]
        public void CelToFahrDouble_ShouldCalculate(double x, double expected)
        {
            double actual = CelFahr.CelToFahrDouble(x);            

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(13, 55.4)]
        [InlineData(-2.5, 27.5)]
        [InlineData(2.9, 37.22)]
        public void FahrToCelDouble_ShouldCalculate(double x, double expected)
        {
            double actual = CelFahr.FahrToCelDouble(x);

            Assert.Equal(actual, expected);
        }
    }
}
