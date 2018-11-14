using System;
using multipliedclasslib;
using Xunit;

namespace multipliedtest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData ("1,2", "[\n\t11,\n\t22\n]")]
        public void Test1(string text, string expected)
        {
            var sut = new multiplied();
            var result = sut.GetFormattedString(text);
            Assert.Equal(expected,result);

        }
    }
}
