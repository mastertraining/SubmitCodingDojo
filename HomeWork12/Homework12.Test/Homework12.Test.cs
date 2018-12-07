using System;
using Xunit;

namespace Homework12.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData('-', "ZXCVBNMASDFGHJ")]
        [InlineData('Z', "ZXCVBNZXCVBMASDFGHJMASDFGHJ")]
        [InlineData('Z', "ZXCZXCVBNMASDFGHJVBNMASZXCVBNMASDFGHJDFGHJ")]
        public void GivenAStringItMustReturnFirstCharacterThatDuplicate(char expected,string inputString)
        {
            var svc = new Lib.Homework12();
            var actual = svc.FirstDuplicateCharactor(inputString);
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData('Z', "ZXCVBNMASDFGHJ")]
        [InlineData('N', "ZXCVBNZXCVBMASDFGHJMASDFGHJ")]
        [InlineData('-', "ZXCZXCVBNMASDFGHJVBNMASZXCVBNMASDFGHJDFGHJ")]
        public void GivenAStringItMustReturnFirstCharacterThatNotDuplicate(char expected, string inputString)
        {
            var svc = new Lib.Homework12();
            var actual = svc.FirstNotDuplicateCharactor(inputString);
            Assert.Equal(expected, actual);
        }
    }
}
