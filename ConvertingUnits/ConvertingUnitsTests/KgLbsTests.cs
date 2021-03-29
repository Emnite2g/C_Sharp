using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Converting_Units;
using Xunit;

namespace ConvertingUnitsTests
{
    public class KgLbsTests
    {
        [Theory]
        [InlineData(70, 155.56)]
        [InlineData(50, 111.11)]
        [InlineData(40.5, 90)]
        public void KgLbsFunction_ShouldCalculate(double x, double expected)
        {

            double actual = KgLbs.KgToLbsFunction(x);            

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(100, 45)]
        [InlineData(135, 60.75)]
        [InlineData(153.6, 69.12)]
        public void LbsKgFunction_ShouldCalculate(double x, double expected)
        {
            double actual = KgLbs.LbsToKgFunction(x);            

            Assert.Equal(expected, actual);
        }                
    }
}
