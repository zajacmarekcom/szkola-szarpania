using Xunit;

namespace App_M24_L3_1.Tests
{
    public class AssertTest
    {
        [Fact]
        public void IsTwoEqualTwo()
        {
            Assert.Equal(2, 2);
            Assert.True(2 == 2);
            Assert.Null(null);
        }
    }
}
