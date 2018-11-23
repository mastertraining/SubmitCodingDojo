using System;
using Xunit;

namespace homework08.Test
{
    public class GetTriangleShapeAsTextTest
    {
        [Theory]
        [InlineData(3, "\r\n  /|\r\n / |\r\n/__|")]
        public void TestGetTriangleShapeAsText(int number, string expectTriangle)
        {
            var sut = new GetTriangleShapeAsTextLogic();
            var result = sut.GetTriangleShapeAsText(number);
            Assert.Equal(expectTriangle, result);
        }
    }
}
