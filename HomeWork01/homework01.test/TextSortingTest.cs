using System;
using homework01.lib;
using Xunit;

namespace homework01.test
{
    public class TextSortingTest
    {
        [Theory(DisplayName = "Text sort is suceess")]
        [InlineData(" w i t h o u t ", "w i t h o u t")]
        [InlineData("without", "without")]
        [InlineData("without,hello", "hello,without")]
        [InlineData("without,hello,bag,world", "bag,hello,without,world")]
        [InlineData(" without,hello,bag,world ", "bag,hello,without,world")]
        [InlineData("without , hello , bag , world", "bag,hello,without,world")]
        public void TextSort_Success(string text, string expected)
        {
            var textSorting = new TextSorting();
            var result = textSorting.SortByAlphabetical(text);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "Text sort is fail")]
        [InlineData("")]
        [InlineData(null)]
        public void TextSort_Fail(string text)
        {
            var textSorting = new TextSorting();
            var result = textSorting.SortByAlphabetical(text);
            Assert.Empty(result);
        }
    }
}
