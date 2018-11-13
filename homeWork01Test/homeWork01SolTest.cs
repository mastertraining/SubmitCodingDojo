using System;
using homeWork01;
using Xunit;


namespace homeWork01Test
{
    public class homeWork01SolTest
    {
        private readonly ITextSorting sut;
         sut = new TextSorting();

        [Theory]
        [InlineData("without,hello,bag,world", "bag,hello,without,world")]
        public void Test1(string text, string expected)
        {
            {
                var result = sut.SortByAlphabetical(text);
                Assert.Equal(expected,result);
            }
        }
    }
}

