using System;
using Xunit;

namespace homework04.Test
{
    public class GetdivisibleTest
    {
        [Theory]
        [InlineData("0100,0011,1010,1001","1010")]
        public void GetDivisibleBy5(string inputString, string expected)
        { 
            var sut = new GetdivisibleLogic();
            var result = sut.GetDivisibleBy5Text(inputString);
            Assert.Equal(expected,result);
        }
    }
}
