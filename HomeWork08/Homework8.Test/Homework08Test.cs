using Homework8.Lib;
using System;
using Xunit;

namespace Homework8.Test
{
    public class Homework08Test
    {
        [Theory]
        [InlineData(@"    /|
   / |
  /  |
 /   |
/____|", 5)]
        [InlineData(@"/|", 1)]
        [InlineData(@"", 0)]
        public void InputANumberOfLineItMustGenerateTriangle(string expected, int inputLine)
        {
            var svc = new Homework08();
            var actual = svc.GetTriangleShapeAsText(inputLine);
            Assert.Equal(expected, actual);
        }
    }
}
