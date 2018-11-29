using System;
using Xunit;

namespace homework12.Test
{
    public class FirstDuplicateCharactorTest
    {
        [Theory]
        [InlineData("ZXCVBNMASDFGHJ", '-')]
        [InlineData("AsviaHcLKEjvDJhFjhfd", 'v')]
        [InlineData("ZXCVBNZXCVBMASDFGHJMASDFGHJ", 'Z')]
        [InlineData("ZXCZXCVBNMASDFGHJVBNMASZXCVBNMASDFGHJDFGHJ", 'Z')]
        public void CheckFirstDuplicateCharactor(string inputString, char expected)
        {
            var sut = new FirstDuplicateCharactorLogic();
            var result = sut.FirstDuplicateCharactor(inputString);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("ZXCVBNMASDFGHJ", 'Z')]
        [InlineData("AsviaHcLKEjvDJhFjhfd", 'A')]
        [InlineData("ZXCVBNZXCVBMASDFGHJMASDFGHJ", 'N')]
        [InlineData("ZXCZXCVBNMASDFGHJVBNMASZXCVBNMASDFGHJDFGHJ", '-')]
        public void CheckFirstNotDuplicateCharactorr(string inputString, char expected)
        {
            var sut = new FirstDuplicateCharactorLogic();
            var result = sut.FirstNotDuplicateCharactor(inputString);
            Assert.Equal(expected, result);
        }
    }
}
