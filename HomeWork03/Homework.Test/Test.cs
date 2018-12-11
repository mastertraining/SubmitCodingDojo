using System;
using System.Collections.Generic;
using Homework.ConsoleApp;
using Xunit;

namespace Homework.Test
{
    public class Test
    {
        [Theory]
        [InlineData(new string[] { "Hello world", "Practice makes perfect" }, new string[] { "HELLO WORLD", "PRACTICE MAKES PERFECT" })]
        [InlineData(new string[] { "Hello world", "Practice makes perfect", "Testing" }, new string[] { "HELLO WORLD", "PRACTICE MAKES PERFECT", "TESTING" })]
        public void TestSortByAlphabetical(string[] text, string[] expectText)
        {
            var sut = new Homework03();
            var result = sut.CapitalizedText(text);
            Assert.Equal(expectText, result);
        }
    }
}
