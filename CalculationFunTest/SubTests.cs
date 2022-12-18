using CalculatorLibrary;


namespace CalculationFunTest
{
    public class SubTests
    {
        [Fact]
        public async Task TestingNegativeNumbers()
        {
            var res = CalculationFunctions.Sub(-5, -9);
            Assert.Equal(4.00, res);
        }
        [Fact]
        public async Task TestingPositiveNumbers()
        {
            var res = CalculationFunctions.Sub(5, 9);
            Assert.Equal(-4.00, res);
        }
        [Fact]
        public async Task TestingSameNegativeNumbers()
        {
            var res = CalculationFunctions.Sub(-5, -5);
            Assert.Equal(0.00, res);
        }
        [Fact]
        public async Task TestingSamepositiveNumbers()
        {
            var res = CalculationFunctions.Sub(5, 5);
            Assert.Equal(0.00, res);
        }
        [Fact]
        public async Task TestingPrimeNumbers()
        {
            var res = CalculationFunctions.Sub(17, 19);
            Assert.Equal(-4.00, res);
        }
        [Fact]
        public async Task GettingSameNumberWithZero()
        {
            var res = CalculationFunctions.Sub(5, 0);
            Assert.Equal(5.0, res);
        }

        [Fact]
        public async Task TestingNegativeDecimals()
        {
            var res = CalculationFunctions.Sub((float)-5.0056, (float)-9.07565);
            Assert.Equal(-4.088866, res);
        }

        [Fact]
        public async Task chekingDataTypeValues()
        {
            float res = CalculationFunctions.Sub((float)587.2654, (float)5874.25656);
            double result = (double)587.2654 - (double)5874.25656;
            Assert.Equal(res, result);
        }
        [Fact]
        public async Task SubtractingTwoZeros()
        {
            var res = CalculationFunctions.Sub(0, 0);
            Assert.Equal(0.0, res);
        }
        [Fact]
        public async Task CheckingResultsfordifferentDataTypes()
        {
            float res = CalculationFunctions.Sub(58, 487);
            int result = 58 - 487;
            Assert.Equal(res, result);
        }
    }
}
