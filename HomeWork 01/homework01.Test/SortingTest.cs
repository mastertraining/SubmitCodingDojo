using System;
using Xunit;

namespace homework01.Test
{
    public class SortingTest
    {
        [Theory(DisplayName="เรียงตามตัวอักษร")]
        [InlineData("without,hello,bag,world", "bag,hello,without,world")]
        [InlineData("bat,cat,ant,bag", "ant,bag,bat,cat")]

        public void SortingText(string inputString, string expected)
        {
            var sut = new TextSorting();
            var result = sut.SortByAlphabetical(inputString);
            Assert.Equal(expected, result);
        }
    }
}
