using System;
using Xunit;

namespace homework07.Test
{
    public class RemoveAndSortTextTest
    {
        [Theory]
        [InlineData("hello world and practice makes perfect and hello world again","again and hello makes perfect practice world")]
        public void Test1(string inputString, string expected)
        {
            var sut = new RemoveAndSortTextLogic();
            var result = sut.RemoveAndSortTextByAlphabetical(inputString);
            Assert.Equal(expected,result);
        }
    }
}
