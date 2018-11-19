using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;

namespace HomeWork05.test
{
    public class LedInputTest
    {
        public static IEnumerable<object[]> ExampleText =>
        new List<object[]>
        {
            new object[] {  "2",  $"[ ] [!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]{Environment.NewLine} 1   2   3   4   5   6   7   8   9   A" },
            new object[] {  "a",  $"[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [!]{Environment.NewLine} 1   2   3   4   5   6   7   8   9   A" },
            new object[] {  "d",  $"[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]{Environment.NewLine} 1   2   3   4   5   6   7   8   9   A" },
            new object[] {  "1",  $"[!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]{Environment.NewLine} 1   2   3   4   5   6   7   8   9   A" },
        };

        [Theory]
        [MemberData(nameof(ExampleText))]
        public void Test1(string input,string expected)
        {
            var sut = new Homework05();
            var result = sut.DisplayLEDOnScreen(input);
            result.Should().Be(expected);
        }
    }
}
