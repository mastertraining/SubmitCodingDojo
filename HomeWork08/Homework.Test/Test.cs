using System;
using System.Collections.Generic;
using Homework.ConsoleApp;
using Xunit;

namespace Homework.Test
{
    public class Test
    {
        [Theory]
        [InlineData(3, "  /|\r\n / |\r\n/__|")]
        [InlineData(4, "   /|\r\n  / |\r\n /  |\r\n/___|")]
        [InlineData(5, "    /|\r\n   / |\r\n  /  |\r\n /   |\r\n/____|")]
        public void TestGetTriangleShapeAsText(int number, string expectTriangle)
        {
            var sut = new Homework08();
            var result = sut.GetTriangleShapeAsText(number);
            Assert.Equal(expectTriangle, result);
        }
    }
}
