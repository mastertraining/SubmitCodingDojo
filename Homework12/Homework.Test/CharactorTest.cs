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
        public void FirstDuplicateCharactor(string text, char expeted)
        {
            var sut = new Charactor();
            var result = sut.FirstDuplicateCharactor(text);
            Assert.Equal(expeted,result);
        }
    }
}
