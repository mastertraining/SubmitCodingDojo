using System;
using Homework.Lib;
using Xunit;

namespace Homework.Test
{
    public class BinaryTest
    {
        [Theory]
        [InlineData("0100,0011,1010,1001","1010")]        
        [InlineData("0100,011,101,1001","101")]
        public void GetDivisibleBy5TextTest(string input, string Exception)
        {
            var sut = new Binary();
            var result = sut.GetDivisibleBy5Text(input);
            Assert.Equal(Exception,result);
        }
    }
}
