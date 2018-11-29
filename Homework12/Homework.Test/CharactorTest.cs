using System;
using Xunit;
using Homework.Lib;

namespace Homework.Test
{
    public class CharactorTest
    {
        [Theory]
        [InlineData("AAcefgqga",'A')]
        [InlineData("nfaghapfwefw",'f')]
        [InlineData("BdoagfaiHB",'B')]
        [InlineData("645698468",'6')]
        [InlineData("JfgagHagagahsjdGkfkFfLlGI",'f')]
        public void FirstDuplicateCharactorTest(string text, char expeted)
        {
            var sut = new Charactor();
            var result = sut.FirstDuplicateCharactor(text);
            Assert.Equal(expeted,result);
        }

        [Theory]
        [InlineData("AAcefgqga",'c')]
        [InlineData("nfaghapfwefw",'n')]
        [InlineData("BdoagfaiHB",'d')]
        [InlineData("645698468",'5')]
        [InlineData("JfgagHagagahsjdGkfkFfLlGI",'J')]
        public void FirstNotDuplicateCharactorTest(string text, char expeted)
        {
            var sut = new Charactor();
            var result = sut.FirstNotDuplicateCharactor(text);
            Assert.Equal(expeted,result);
        }
    }
}
