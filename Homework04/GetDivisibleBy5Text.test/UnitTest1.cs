using System;
using Xunit;
using GetDivisibleBy5Text.lib;

namespace GetDivisibleBy5Text.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IHomework04 sut = new Homework04();
            var actual = sut.GetDivisibleBy5Text("0100,0011,1010,1001,0101");
            var expected = "1010,0101";
            Assert.Equal(expected,actual);
        }
    }
}
