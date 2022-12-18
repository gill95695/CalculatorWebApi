

using CalculatorLibrary;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace CalculationFunTest
{
    public class AddTests
    {
        [Fact]
        public async Task TestingNegativeNumbers()
        {
            var res = CalculationFunctions.Add(-5, -9);
            Assert.Equal(14.00, res);
        }
        [Fact]
        public async Task TestingPositiveNumbers()
        {
            var res = CalculationFunctions.Add(5, 9);
            Assert.Equal(14.00, res);
        }
        [Fact]
        public async Task TestingSameNegativeNumbers()
        {
            var res = CalculationFunctions.Add(-5, -5);
            Assert.Equal(-10.00, res);
        }
        [Fact]
        public async Task TestingSameNumbers()
        {
            var res = CalculationFunctions.Add(5, 5);
            Assert.Equal(10.00, res);
        }
        [Fact]
        public async Task TestingPrimeNumbers()
        {
            var res = CalculationFunctions.Add(17, 19);
            Assert.Equal(36.00, res);
        }
        [Fact]
        public async Task GettingSameNumberWithZero()
        {
            var res = CalculationFunctions.Add(5, 0);
            Assert.Equal(5.0, res);
        }

        [Fact]
        public async Task TestingNegativeDecimals()
        {
            var res = CalculationFunctions.Add((float)-5.0056, (float)-9.07565);
            Assert.Equal(-14.088866, res);
        }

        [Fact]
        public async Task chekingDataTypeValues()
        {
            float res = CalculationFunctions.Add((float)587.2654, (float)5874.25656);
            var result = (double) 587.2654 + 5874.25656;
            Assert.Equal(res, result);
        }
        [Fact]
        public async Task AddingTwoZeros()
        {
            var res = CalculationFunctions.Add(0, 0);
            Assert.Equal(0.0, res);
        }
        [Fact]
        public async Task CheckingResultsfordifferentDataTypes()
        {
            float res = CalculationFunctions.Add(58, 487);
            int result = 58 + 487;
            Assert.Equal(res, result);
        }

    }
}
