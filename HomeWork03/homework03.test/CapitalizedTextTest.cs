using System;
using Xunit;
using homework03.lib;
using System.Collections.Generic;
using FluentAssertions;

namespace homework03.test
{
    public class CapitalizedTextTest
    {
        private Homework03 _homework;

        public CapitalizedTextTest()
        {
            _homework = new Homework03();
        }

        public static IEnumerable<object[]> TestCaseSuccesses = new List<object[]>
        {
            new object[] { new [] { "Hello world" }, new [] { "HELLO WORLD" } },
            new object[] { new [] { "Hello world", "Practice makes perfect" }, new [] { "HELLO WORLD", "PRACTICE MAKES PERFECT" } },
            new object[] { new [] { "Hello world", "Practice makes perfect", "Hello world" }, new [] { "HELLO WORLD", "PRACTICE MAKES PERFECT", "HELLO WORLD" } }
        };

        public static IEnumerable<object[]> TestCaseFails = new List<object[]>
        {
            new object[] { new [] { "" } },
            new object[] { null },
            new object[] { new [] { "", null } },
            new object[] { new [] { "Hello world", "" } },
            new object[] { new [] { "", "Practice makes perfect" } }
        };

        [Theory(DisplayName = "CapitalizedText is success")]
        [MemberData(nameof(TestCaseSuccesses))]
        public void CapitalizedText_Success(string[] text, string[] expected)
        {
            var result = _homework.CapitalizedText(text);
            result.Should().BeEquivalentTo(expected);
        }


        [Theory(DisplayName = "CapitalizedText is fail")]
        [MemberData(nameof(TestCaseFails))]
        public void CapitalizedText_Fail(string[] text)
        {
            var result = _homework.CapitalizedText(text);
            result.Should().BeEmpty();
        }

    }
}
