using System;
using homework2;
using Xunit;

namespace testhomework2
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1", "[\n\t11\n]")]
        [InlineData("2", "[\n\t22\n]")]
        [InlineData("1,2", "[\n\t11,\n\t22\n]")]
        public void Test1(string text, string excepted)
        {
            var numbers = new number();
            var result = numbers.GetFormattedString(text);
            Assert.Equal(excepted, result);

        }
    }
}
