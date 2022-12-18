using CalculatorLibrary;
using FluentAssertions;
namespace CalculationFunTest
{
    public class DivideTests
    {
        [Fact]
        public async Task TestingNegativeNumbers()
        {
            var res = CalculationFunctions.divide(-5, -9);
            Assert.Equal(- 0.555, res);
        }
        [Fact]
        public async Task TestingPositiveNumbers()
        {
            var res = CalculationFunctions.divide(5, 9);
            Assert.Equal(0.555, res);
        }
        [Fact]
        public async Task TestingSameNegativeNumbers()
        {
            var res = CalculationFunctions.divide(-5, -5);
            Assert.Equal(-1, res);
        }
        [Fact]
        public async Task TestingSamepositiveNumbers()
        {
            var res = CalculationFunctions.divide(5, 5);
            Assert.Equal(1.00, res);
        }
        [Fact]
        public async Task TestingPrimeNumbers()
        {
            var res = CalculationFunctions.divide(17, 19);
            Assert.Equal(0.894, res);
        }
        [Fact]
        public async Task DividingAZeroWithNumber()
        {
            var res = CalculationFunctions.divide(0, 5);
            Assert.Equal(5.0, res);
        }

        [Fact]
        public async Task TestingNegativeDecimals()
        {
            var res = CalculationFunctions.divide((float)-5.0056, (float)-9.07565);
            Assert.Equal(-0.55154, res);
        }

        [Fact]
        public async Task chekingDataTypeValues()
        {
            float res = CalculationFunctions.divide((float)587.2654, (float)5874.25656);
            double result = (double)587.2654 / (double)5874.25656;
            Assert.Equal(res, result);
        }
        [Fact]
        public async Task DividingTwoZeros()
        {
            Assert.Throws<DivideByZeroException>(() => CalculationFunctions.divide(0, 0));
        }
        [Fact]
        public async Task CheckingResultsfordifferentDataTypes()
        {
            float res = CalculationFunctions.divide(58, 487);
            int result = 58 / 487;
            Assert.Equal(res, result);
        }
        [Fact]
        public async Task divingANumberWithZero()
        {
            Assert.Throws<DivideByZeroException>(() => CalculationFunctions.divide(0, 0));
        }
    }
}
