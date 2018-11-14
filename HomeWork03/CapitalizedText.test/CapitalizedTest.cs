using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;

namespace CapitalizedText.test
{
    public class CapitalizedTest
    {
        public static IEnumerable<object[]> ExampleText =>
        new List<object[]>
        {
            new object[] { new string[] { "Hello world", "Practice makes perfect" }, new string[] {"HELLO WORLD","PRACTICE MAKES PERFECT" } },
            new object[] { new string[] { "One", "Two" }, new string[] {"ONE","TWO" } },
            new object[] { new string[] { "" }, new string[] { "" } },
            new object[] { new string[] { "1" }, new string[] { "1" } },
        };

        [Theory]
        [MemberData(nameof(ExampleText))]
        public void Capitalized(string[] input,string[] expected)
        {
            var sut = new Homework03();
            var result = sut.CapitalizedText(input);
            result.Should().BeEquivalentTo(expected);
        }
    }
}
