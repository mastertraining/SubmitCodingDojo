using System;
using Homework.ConsoleApp;
using Xunit;

namespace Homework.Test
{
    public class Test
    {
        [Theory]
        [InlineData("34,67,55,33,12,28", new string[] { "374", "737", "605", "363", "132", "308" })]
        [InlineData("1,2,3,4,5", new string[] { "11", "22", "33", "44", "55" })]
        [InlineData("10,11,12,9,8", new string[] { "110", "121", "132", "99", "88" })]
        public void TestSortByAlphabetical(string text, string[] expectNumber)
        {
            var sut = new TextMultiplier();
            var result = sut.ConvertTextToArrayMultipliedBy11(text);
            Assert.Equal(expectNumber, result);
        }
    }
}
