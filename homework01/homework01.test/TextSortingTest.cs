using System;
using homework01.lib;
using Xunit;

namespace homework01.test
{
    public class TextSortingTest
    {
        [Theory]
        [InlineData("without,hello,bag,world", "bag,hello,without,world")]
        public void Test(string text, string expected)
        {
            {
                var sut = new TextSorting();
                var result = sut.SortByAlphabetical(text);
                Assert.Equal(expected, result);
            }
        }
    }
}
