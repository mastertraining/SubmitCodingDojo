using System;
using Xunit;

namespace homework12.Test
{
    public class FirstDuplicateCharactorTest
    {
        [Theory]
        [InlineData("ZXCVBNMASDFGHJ",'-')]
        public void CheckFirstDuplicateCharactor(string inputString, char expected)
        {
            var sut = new FirstDuplicateCharactorLogic();
            var result = sut.FirstDuplicateCharactor(inputString);
            Assert.Equal(expected, result);
        }

        // [Theory]
        // [InlineData("ZXCVBNMASDFGHJ",'Z')]
        // public void CheckFirstNotDuplicateCharactorr(string inputString, char expected)
        // {
        //     var sut = new FirstDuplicateCharactorLogic();
        //     var result = sut.FirstNotDuplicateCharactor(inputString);
        //     Assert.Equal(expected, result);
        // }
    }
}
