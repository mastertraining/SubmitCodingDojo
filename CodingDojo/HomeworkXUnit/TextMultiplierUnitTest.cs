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
        public TextMultiplierUnitTest() => ITM = new TextMultiplier();

        [Theory]
        [MemberData(nameof(GetFormattedStringCase))]
        public void GetFormattedStringShouldWork(string text, string expected)
        {
            var result = ITM.GetFormattedString(text);
            result.Should().Be(expected);
        }

        public static IEnumerable<object[]> GetFormattedStringCase => new List<object[]>
        {
            new object[]{"34,67,55,33,12,28",
                $"[{Environment.NewLine}\t374,{Environment.NewLine}\t737,{Environment.NewLine}\t605,{Environment.NewLine}\t363,{Environment.NewLine}\t132,{Environment.NewLine}\t308{Environment.NewLine}]" }
        };
    }
}
