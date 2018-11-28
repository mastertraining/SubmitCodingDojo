using FluentAssertions;
using Homework01;
using Xunit;

namespace HomeworkXUnit
{
    public class TextSortingUnitTest
    {
        private ITextSorting ITS;
        public TextSortingUnitTest() => ITS = new TextSorting();

        [Theory]
        [InlineData("without,hello,bag,world", "bag,hello,without,world")]
        public void SortByAlphabeticalShouldWork(string text, string expected)
        {
            var result = ITS.SortByAlphabetical(text);
            result.Should().Be(expected);
        }
    }
}
