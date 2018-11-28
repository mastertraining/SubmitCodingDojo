using System;
using Xunit;
using homework12.lib;

namespace homework12.test
{
    public class FirstDuplicateCharactorTest
    {
        private Homework12 textComparison;

        public FirstDuplicateCharactorTest() => textComparison = new Homework12();

        [Theory(DisplayName = "Find first duplicated charactor correctly")]
        [InlineData("", '-')]
        [InlineData(" ", '-')]
        [InlineData(null, '-')]
        [InlineData("AbDaBaCdAbBDg", 'A')]
        [InlineData("ZXCVBNMASDFGHJ", '-')]
        [InlineData("ZXCVBNZXCVBMASDFGHJMASDFGHJ", 'Z')]
        [InlineData("ZXCZXCVBNMASDFGHJVBNMASZXCVBNMASDFGHJDFGHJ", 'Z')]
        public void FindFirstDuplicateCharactorCorrectly(string text, char expectedResult)
        {
            var result = textComparison.FirstDuplicateCharactor(text);
            Assert.Equal(expectedResult, result);
        }
    }
}
