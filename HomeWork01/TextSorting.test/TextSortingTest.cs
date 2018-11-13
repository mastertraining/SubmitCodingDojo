using System;
using Xunit;

namespace TextSorting.test
{
    public class TextSortingTest
    {
        [Theory(DisplayName = "TextSplitTest success")]
        [InlineData("w i t h o u t", "w i t h o u t")]
        [InlineData("without", "without")]
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
