using System;
using Xunit;

namespace TextSorting.test
{
    public class TextSortingTest
    {
        [Theory]
        [InlineData("without,hello,bag,world", "bag,hello,without,world")]
        [InlineData("cass,asss,bass,rass", "asss,bass,cass,rass")]
        [InlineData("zero,hero", "hero,zero")]
        public void TextSplitTest(string input, string expected)
        {
            var sut = new TextSorting();
            var result = sut.SortByAlphabetical(input);
            Assert.Equal(expected,result);
        }
    }
}
