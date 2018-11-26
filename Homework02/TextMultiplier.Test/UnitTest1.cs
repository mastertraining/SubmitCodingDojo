using System;
using TextMultiplier.Lib;
using Xunit;

namespace TextMultiplier.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ITextMultiplier sut = new Homework02();
            var actual = sut.GetFormattedString("34,67,55,33,12,28");
            var expected = "[\n\t374,\n\t737,\n\t605,\n\t363,\n\t132,\n\t308\n]";
            Assert.Equal(expected, actual);
        }
    }
}
