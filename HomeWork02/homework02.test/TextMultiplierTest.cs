using System;
using homework02.lib;
using Xunit;

namespace homework02.test
{
    public class TextMultiplierTest
    {
        [Theory(DisplayName = "Text multiplier is success")]
        [InlineData(" 3 4 ", "[\n\n]")]
        [InlineData(" 34 ", "[\n\t374\n]")]
        [InlineData("34", "[\n\t374\n]")]
        [InlineData("34,67,55,33,12,28", "[\n\t374,\n\t737,\n\t605,\n\t363,\n\t132,\n\t308\n]")]
        [InlineData(" 34,67,55,33,12,28 ", "[\n\t374,\n\t737,\n\t605,\n\t363,\n\t132,\n\t308\n]")]
        [InlineData(" 34 , 67 , 55 , 33 , 12 , 28 ", "[\n\t374,\n\t737,\n\t605,\n\t363,\n\t132,\n\t308\n]")]
        public void TextMultiplierTest_success(string text, string expected)
        {
            var textMultiplier = new TextMultiplier();
            var result = textMultiplier.GetFormattedString(text);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "Text multiplier is fail")]
        [InlineData("")]
        [InlineData(null)]
        public void TextMultiplierTest_fail(string text)
        {
            var textMultiplier = new TextMultiplier();
            var result = textMultiplier.GetFormattedString(text);
            Assert.Empty(result);
        }
    }
}
