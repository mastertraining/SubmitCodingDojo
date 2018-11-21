using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;

namespace Homework06.test
{
    public class Homework06Test
    {
        public static IEnumerable<object[]> ExampleText =>
        new List<object[]>
        {
            new object[] {  "2",  $"[ ] [*] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]{Environment.NewLine} 1   2   3   4   5   6   7   8   9   A" },
        };

        [Theory]
        [MemberData(nameof(ExampleText))]
        public void Test1(string input, string expected)
        {
            var sut = new Homework06();
            var result = sut.DisplayLEDOnScreen(input);
            result.Should().Be(expected);
        }
    }
}
