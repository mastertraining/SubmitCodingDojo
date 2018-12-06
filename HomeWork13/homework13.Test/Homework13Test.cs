using System;
using System.Collections.Generic;
using Xunit;

namespace homework13.Test
{
    public class Homework13Test
    {
        [Fact]
        public void CheckNinetyNineResult()
        {
            var expected = 6;
            var sut = new Homework13Logic();
            var numbers = new List<int> { 000099, 009900, 990000, 990999, 919909, 999799 };
            var result = sut.Homework13(numbers);
            Assert.Equal(expected, result);
        }
    }
}
