using System;
using System.Collections.Generic;
using homework13classlib;
using Xunit;

namespace homework13Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0099, 1)]
        public void Test1(int input, int expected)
        {
            int[] arrayinput = new int[]{input};
            var sut = new homework13Logic();
            var result = sut.Homework13(arrayinput);
            Assert.Equal(expected, result);
        }
    }
}
