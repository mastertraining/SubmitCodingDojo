using Homework01.Lib;
using System;
using Xunit;

namespace Homework01.Test
{
    public class TextSortingTest
    {
        [Theory]
        [InlineData("bag,hello,without,world", "without,hello,bag,world")]
        [InlineData("annmen,anntony,catagory,wintersoilder", "wintersoilder,anntony,annmen,catagory")]
        [InlineData("wintersoilder@annmen@catagory", "wintersoilder@annmen@catagory")]
        public void InputTextThatMatchPlatternItCanBeSorting(string expected, string inputString)
        {
            var sortingSvc = new TextSorting();
            var actual = sortingSvc.SortByAlphabetical(inputString);
            Assert.Equal(expected, actual);
        }
    }
}