using System;
using Xunit;

namespace Homework08.test
{
    public class Homework08Test
    {
        [Theory]
        [InlineData(5, "    /|\r\n   / |\r\n  /  |\r\n /   |\r\n/____|")]
        [InlineData(3, "  /|\r\n / |\r\n/__|")]
        [InlineData(1, "Please enter a number that is greater than 1.")]
        public void Test1(int input, string expected)
        {
            var sut = new Homework08();
            var result = sut.GetTriangleShapeAsText(input);
            Assert.Equal(expected, result);
        }
    }
}
