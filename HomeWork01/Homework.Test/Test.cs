using System;
using Homework.ConsoleApp;
using Xunit;

namespace Homework.Test
{
    public class Test
    {
        [Theory]
        [InlineData("without,hello,bag,world","bag,hello,without,world")]
        [InlineData("bag,hello,without,world","bag,hello,without,world")]
        [InlineData("bag,Aello,without,world","Aello,bag,without,world")]
        [InlineData("Zag,Aello,without,world","Aello,without,world,Zag")]
        public void TestSortByAlphabetical(string text,string expectText)
        {
            var sut = new TextSorting();
            var result = sut.SortByAlphabetical(text);
            Assert.Equal(expectText, result);
        }
    }
}
