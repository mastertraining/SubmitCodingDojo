using System;
using Xunit;

namespace multipliedtest
{
    public class UnitTest1
    {
        [Theory(DisplayName = "ผลคูณ")]
        [InlineData("34,67,55,33,12,28", "374,737,605,363,132,308")]
        public void multiplied(string text, string expected)
        {
            var sut = new multiplied();
            var result = sut.GetFormattedString(text);
            Assert.Equal(expected, result);

        }
    }
}
