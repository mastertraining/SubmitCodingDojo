using System;
using Xunit;
using homework08.lib;

namespace homework08.test
{
    public class GetTriangleShapeAsTextTest
    {
        [Theory(DisplayName = "GetTriangleShapeAsTextTest is success")]
        [InlineData(1,"/|\r\n")]
        [InlineData(2," /|\r\n/_|\r\n")]
        [InlineData(3,"  /|\r\n / |\r\n/__|\r\n")]
        [InlineData(4,"   /|\r\n  / |\r\n /  |\r\n/___|\r\n")]
        [InlineData(5,"    /|\r\n   / |\r\n  /  |\r\n /   |\r\n/____|\r\n")]
        public void GetTriangleShapeAsText_Success(int input, string expected)
        {
            var drawShapeCalculate = new Homework08();
            var result = drawShapeCalculate.GetTriangleShapeAsText(input);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "GetTriangleShapeAsTextTest is fail")]
        [InlineData(-1)]
        [InlineData(0)]
        public void GetTriangleShapeAsText_Fail(int input)
        {
            var drawShapeCalculate = new Homework08();
            var result = drawShapeCalculate.GetTriangleShapeAsText(input);
            Assert.Empty(result);
        }
    }
}
