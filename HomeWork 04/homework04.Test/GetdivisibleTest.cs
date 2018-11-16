using System;
using Xunit;

namespace homework04.Test
{
    public class GetdivisibleTest
    {
        [Theory]
        [InlineData("0100,0011,1010,1001", "1010")]
        [InlineData("000,0101,101,1001", "0101")]
        [InlineData("1110,1111,100,001", "1111")]
        public void GetDivisibleBy5(string inputString, string expected)
        {
            var sut = new GetdivisibleLogic();
            var result = sut.GetDivisibleBy5Text(inputString);
            Assert.Equal(expected, result);
        }
    }
}
