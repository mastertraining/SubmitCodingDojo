using System;
using hw4ClassLib;
using Xunit;

namespace hw4Test
{
    public class TestHomework04
    {
        [Theory]
        [InlineData("0100,0011,1010,1001", "1010")]

        public void TestSortByAlphabetical(string text, string expectText)
        {
            var sut = new Homework04();
            var result = sut.GetDivisibleBy5Text(text);
            Assert.Equal(expectText, result);
        }
    }
}
