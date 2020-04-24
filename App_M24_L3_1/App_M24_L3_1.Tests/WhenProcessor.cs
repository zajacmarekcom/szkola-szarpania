using Xunit;

namespace App_M24_L3_1.Tests
{
    public class WhenProcessor
    {
        [Fact]
        public void HasCalculatorWithPositiveValues_ThenDoWithValue_1_ShouldReturnZeroResult()
        {
            var processor = new Processor(new Calculator(2, 4.0M));

            var result = processor.Do(2.0M);

            Assert.Equal(0.0M, result.Value);
            Assert.Equal("WRONG", result.Desc);
        }
    }
}
