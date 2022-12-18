using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationFunTest
{
    public class MultiTest
    {
            [Fact]
            public async Task TestingNegativeNumbers()
            {
                var res = CalculationFunctions.Multi(-5, -9);
                Assert.Equal(45, res);
            }
            [Fact]
            public async Task TestingPositiveNumbers()
            {
                var res = CalculationFunctions.Multi(5, 9);
                Assert.Equal(45, res);
            }
            [Fact]
            public async Task TestingSameNegativeNumbers()
            {
                var res = CalculationFunctions.Multi(-5, -5);

                Assert.Equal(25, res);
            }
            [Fact]
            public async Task TestingSamepositiveNumbers()
            {
                var res = CalculationFunctions.Multi(5, 5);
                
                Assert.Equal(25, res);
            }
        public async Task MatchingResultWithDifferentSigns()
        {
            var res = CalculationFunctions.Multi(5, 9);
            var result = CalculationFunctions.Multi(-5, -9);
            Assert.Equal(result, res);
        }

        [Fact]
            public async Task TestingPrimeNumbers()
            {
                var res = CalculationFunctions.Multi(17, 19);
                Assert.Equal(587, res);
            }
            [Fact]
            public async Task GettingZeroByMultiplyingWithZero()
            {
                var res = CalculationFunctions.Multi(5, 0);
                Assert.Equal(0, res);
            }

            [Fact]
            public async Task TestingNegativeDecimals()
            {
                var res = CalculationFunctions.Multi((float)-5.0056, (float)-9.07565);
                Assert.Equal(-36.2545455, res);
            }

            [Fact]
            public async Task chekingDataTypeValues()
            {
                float res = CalculationFunctions.Multi((float)587.2654, (float)5874.25656);
                double result = (double)587.2654 * (double)5874.25656;
                Assert.Equal(res, result);
            }
            [Fact]
            public async Task MutlipllyingTwoZeros()
            {
                var res = CalculationFunctions.Multi(0, 0);
                Assert.Equal(0.0, res);
            }
            [Fact]
            public async Task CheckingResultsfordifferentDataTypes()
            {
                float res = CalculationFunctions.Multi(58, 487);
                int result = 58 * 487;
                Assert.Equal(res, result);
            }
        }
}
