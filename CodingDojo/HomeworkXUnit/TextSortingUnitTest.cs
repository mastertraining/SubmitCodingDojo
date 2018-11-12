using FluentAssertions;
using Homework_01;
using System;
using Xunit;

namespace HomeworkXUnit
{
    public class TextSortingUnitTest
    {
        private ITextSorting ITS;

        public TextSortingUnitTest()
        {
            ITS = new TextSorting();
        }

        [Theory]
        [InlineData("without,hello,bag,world", "bag,hello,without,world")]
        public void Test1(string text, string expected)
        {
            var result = ITS.SortByAlphabetical(text);
            result.Should().Be(expected);
        }
    }
}
