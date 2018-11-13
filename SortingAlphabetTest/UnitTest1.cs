using System;
using SortingAlphabetclasslib;
using Xunit;

namespace SortingAlphabetTest
{
    public class UnitTest1
    {
        [Theory(DisplayName = "เรียงตัวอักษรใหม่")]
        [InlineData("guitar,electon,piano,panda", "electon,guitar,panda,piano")]
        [InlineData("guitar,electon,piano,panda,paacda", "electon,guitar,paacda,panda,piano")]
        [InlineData("without,hello,bag,world", "bag,hello,without,world")]
        public void Test1(string text, string expected)
        {
            var sut = new SortingAlphabets();
            var result = sut.SortByAlphabetical(text);
            Assert.Equal(expected, result);

        }

    }
}
