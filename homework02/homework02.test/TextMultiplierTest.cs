using System;
using homework02.lib;
using Xunit;

namespace homework02.test
{
    public class TextMultiplierTest
    {
        [Theory]
        [InlineData("34,67,55,33,12,28", "[\n\t374,\n\t737,\n\t605,\n\t363,\n\t132,\n\t308\n]")]
        [InlineData("78,38,26,68,28,45", "[\n\t858,\n\t418,\n\t286,\n\t748,\n\t308,\n\t495\n]")]
        [InlineData("23,78,17,21,15", "[\n\t253,\n\t858,\n\t187,\n\t231,\n\t165\n]")]
        public void Test(string text, string expected)
        {
            {
                var sut = new TextMultiplier();
                var result = sut.GetFormattedString(text);
                Assert.Equal(expected, result);
            }
        }
    }
}
