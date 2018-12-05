using System;
using Xunit;
using homework04.lib;

namespace homework04.test
{
    public class GetDivisibleBy5TextTest
    {
        [Theory(DisplayName = "GetDivisibleBy5Text is success")]
        [InlineData("0100,0011", "")]
        [InlineData("1010", "1010")]
        [InlineData("0100,0011,1010,1001", "1010")]
        [InlineData("0100,0011,1010,1001,1010", "1010,1010")]
        public void GetDivisibleBy5Text_Success(string text, string expected)
        {
            var hw = new Homework04();
            var result = hw.GetDivisibleBy5Text(text);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "GetDivisibleBy5Text is fail")]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("0100,0011,1010,10001")]
        public void GetDivisibleBy5Text_Fail(string text)
        {
            var hw = new Homework04();
            var result = hw.GetDivisibleBy5Text(text);
            Assert.Empty(result);
        }
    }
}
