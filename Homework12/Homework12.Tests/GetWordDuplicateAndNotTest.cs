using Xunit;

namespace Homework12.Tests
{
    public class GetWordDuplicateAndNotTest
    {
        [Theory(DisplayName = "∑¥ Õ∫À“µ—«·√°∑’Ë´È”")]
        [InlineData("AsviaHcLKEjvDJhFjhfd", 'v')]
        [InlineData("", '-')]
        [InlineData("ZXCVBNMASDFGHz", '-')]
        [InlineData("ZXCVBNMASDFGHJ", '-')]
        [InlineData("ZXCZXCVBNMASDFGHJVBNMASZXCVBNMASDFGHJDFGHJ", 'Z')]
        public void FirstDuplicateTest(string input, char expected)
        {
            var sut = new Homework12();
            var actual = sut.FirstDuplicateCharactor(input);
            Assert.Equal(expected, actual);
        }

        [Theory(DisplayName = "∑¥ Õ∫À“µ—«·√°‰¡Ë´È”")]
        [InlineData("", '-')]
        [InlineData("ZXCVBNMASDFGHJ", 'Z')]
        [InlineData("AsviaHcLKEjvDJhFjhfd", 'A')]
        [InlineData("ZXCZXCVBNMASDFGHJVBNMASZXCVBNMASDFGHJDFGHJ", '-')]
        public void FirstNotDuplicateTest(string input, char expected)
        {
            var sut = new Homework12();
            var actual = sut.FirstNotDuplicateCharactor(input);
            Assert.Equal(expected, actual);
        }
    }
}
