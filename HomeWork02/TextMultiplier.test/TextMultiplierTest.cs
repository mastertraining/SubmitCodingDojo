using System;
using Xunit;

namespace TextMultiplier.test
{
    public class TextMultiplierTest
    {
        [Theory(DisplayName = "MulitplierTest")]
        [InlineData("34,67,55,33,12,28", "374,737,605,363,132,308")]
        [InlineData("22,99","242,1089")]
        public void MulitplierTest (string input, string expected)
        {
            var sut = new TextMultiplier();
            var result = sut.GetMultiplierText(input);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "MulitplierTest")]
        [InlineData("34,67,55,33,12,28", "[\n\t374,\n\t737,\n\t605,\n\t363,\n\t132,\n\t308\n]")]
        [InlineData("22,99", "[\n\t242,\n\t1089\n]")]
        public void FormattedTest(string input, string expected)
        {
            var sut = new TextMultiplier();
            var result = sut.GetFormattedString(input);
            Assert.Equal(expected, result);
        }
    }
}
