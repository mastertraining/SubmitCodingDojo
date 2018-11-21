using System;
using Xunit;

namespace Homework07.test
{
    public class RemoveAndSortTextTest
    {
        [Theory(DisplayName = "ลบตัวซ้ำและเรียงลำดับตามตัวอักษร")]
        [InlineData("hello world and practice makes perfect and hello world again", "again and hello makes perfect practice world")]
        [InlineData("world and world world world and and and and and", "and world")]
        public void RemoveAndSortText(string input,string expected)
        {
            var sut = new Homework07();
            var result = sut.RemoveAndSortTextByAlphabetical(input);
            Assert.Equal(expected,result);
        }
    }
}
