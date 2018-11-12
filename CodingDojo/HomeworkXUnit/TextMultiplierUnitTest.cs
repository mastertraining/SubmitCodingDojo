using FluentAssertions;
using Homework_02;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HomeworkXUnit
{
    public class TextMultiplierUnitTest
    {
        private ITextMultiplier ITM;

        public TextMultiplierUnitTest()
        {
            ITM = new TextMultiplier();
        }

        [Theory]
        [InlineData("34,67,55,33,12,28", "[\n\t374,\n\t737,\n\t605,\n\t363,\n\t132,\n\t308\n]")]
        public void GetFormattedStringShouldWork(string text, string expected)
        {
            var result = ITM.GetFormattedString(text);
            result.Should().Be(expected);
        }
    }
}
