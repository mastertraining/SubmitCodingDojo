using System;
using Xunit;

namespace homework02.Test
{
    public class TextMultiplierTest
    {
        [Theory(DisplayName="ผลคูณด้วย11 เว้นบรรทัด และ แทบ")]
        [InlineData("34,67,55,33,12,28","[\n\t374,\n\t737,\n\t605,\n\t363,\n\t132,\n\t308\n]")]
        public void TextMultiplierBy11(string inputString, string expected)
        {
            var sut = new Multiplier();
            var result = sut.GetFormattedString(inputString);
            Assert.Equal(expected,result);
        }
    }
}
