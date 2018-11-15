using System;
using Xunit;
using FluentAssertions;

namespace DivisibleBy5Text.test
{
    public class DivisibleBy5Test
    {
        [Theory]
        [InlineData("0100,0011,1010,1001", "1010")]
        [InlineData("1010,0100,0011,1010,1001", "1010,1010")]
        public void DivisibleBy5TextTest(string input, string expected)
        {
            var sut = new Homework04();
            var result = sut.GetDivisibleBy5Text(input);
            result.Should().Be(expected);
        }

    }
}
