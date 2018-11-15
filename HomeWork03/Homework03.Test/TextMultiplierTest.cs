using Homework02.Lib;
using System;
using Xunit;

namespace Homework02.Test
{
    public class TextMultiplierTest
    {
        [Theory]
        [InlineData("[\n\t374,\n\t737,\n\t605,\n\t363,\n\t132,\n\t308\n]", "34,67,55,33,12,28")]
        [InlineData("[\n\t22,\n\t737,\n\t605,\n\t121,\n\t1375,\n\t396\n]", "2,67,55,11,125,36")]
        public void InputStringThatMatchPlatternItCanMultiplyWith11AndConvertToSpecificPlattern(string expected, string inputString)
        {
            var textMultiplierSvc = new TextMultiplier();
            var actual = textMultiplierSvc.GetFormattedString(inputString);
            Assert.Equal(expected,actual);
        }
    }
}