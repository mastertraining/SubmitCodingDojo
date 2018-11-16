using System;
using testhome;
using Xunit;

namespace testhomework4
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1111,4565,1455,5521","1111")]
        [InlineData("1111,4565,101,5521","1111,101")]
        [InlineData("1111,0101,1455,1010","1111,0101,1010")]
        public void Test1(string text , string excepted)
        {
            var a = new testlogic();
            var result = a.GetDivisibleBy5Text(text);
            Assert.Equal(excepted, result);


        }
    }
}
