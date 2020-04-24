using Xunit;

namespace App_M24_L3_1.Tests
{
    public class WhenCalculator
    {
        [Fact]
        public void HasSetPositiveMultiplicatorAndBase_ThenCalcWithPositiveValueShouldReturnPositiveResult()
        {
            var calculator = new Calculator(2, 4.0M);

            var result = calculator.Calc(2.0M);

            Assert.True(result > 0.0M);
        }

        [Fact]
        public void HasSetPositiveMultiplicatorAndBase_ThenCalcWithNegativeValueShouldReturnPositiveResult()
        {
            var calculator = new Calculator(2, 4.0M);

            var result = calculator.Calc(-2.0M);

            Assert.True(result < 0.0M);
        }

        [Fact]
        public void HasSetMultiplicatorAndBase_ThenCalcShouldReturnCorrectResult()
        {
            var calculator = new Calculator(2, 4.0M);

            var result = calculator.Calc(2.0M);

            Assert.Equal(1.0M, result, 4);
        }
    }
}
