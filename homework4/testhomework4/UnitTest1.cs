using System;
using testhome;
using Xunit;

namespace testhomework4
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1111,1001","1111")]
        [InlineData("1111,1110,101,0111","1111,101")]
        [InlineData("1111,0101,1110,1010","1111,0101,1010")]
        public void Test1(string text , string excepted)
        {
            var a = new testlogic();
            var result = a.GetDivisibleBy5Text(text);
            Assert.Equal(excepted, result);


        }
    }
}
