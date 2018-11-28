using System;
using Xunit;
using homework12.lib;

namespace homework12.test
{
    public class FirstNotDuplicateCharactorTest
    {
        private Homework12 textComparison;

        public FirstNotDuplicateCharactorTest() => textComparison = new Homework12();

        [Theory(DisplayName = "Find first duplicated charactor correctly")]
        [InlineData("", '-')]
        [InlineData(" ", '-')]
        [InlineData(null, '-')]
        [InlineData("AbDaBaCdAbBDg", 'C')]
        [InlineData("ZXCVBNMASDFGHJ", 'Z')]
        [InlineData("ZXCVBNZXCVBMASDFGHJMASDFGHJ", 'N')]
        [InlineData("ZXCZXCVBNMASDFGHJVBNMASZXCVBNMASDFGHJDFGHJ", '-')]
        public void FindFirstNotDuplicateCharactorCorrectly(string text, char expectedResult)
        {
            var result = textComparison.FirstNotDuplicateCharactor(text);
            Assert.Equal(expectedResult, result);
        }
    }
}
