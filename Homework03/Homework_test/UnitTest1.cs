using System;
using Homework03_classlib;
using Xunit;

namespace Homework_test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new string[] { "Hello world", "Practice makes perfect" }, new string[] { "HELLO WORLD", "PRACTICE MAKES PERFECT" })]
        [InlineData(new string[] { "Hello world", "sirisak", "sunon", "men" }, new string[] { "HELLO WORLD", "SIRISAK", "SUNON", "MEN" })]
        public void TestSortByAlphabetical(string[] text, string[] expectText)
        {
            var sut = new Homework03();
            var result = sut.CapitalizedText(text);
            Assert.Equal(expectText, result);
        }
    }
}
