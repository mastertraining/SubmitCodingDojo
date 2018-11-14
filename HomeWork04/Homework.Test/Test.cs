using System;
using System.Collections.Generic;
using Homework.ConsoleApp;
using Xunit;

namespace Homework.Test
{
    public class Test
    {
        [Theory]
        [InlineData("0100,0011,1010,1001", "1010")]
        [InlineData("0100,0011,1010,0101", "1010,0101")]
        [InlineData("0100,0011,1010,1001,0101", "1010,0101")]
        public void TestSortByAlphabetical(string text, string expectText)
        {
            var sut = new Homework04();
            var result = sut.GetDivisibleBy5Text(text);
            Assert.Equal(expectText, result);
        }
    }
}
