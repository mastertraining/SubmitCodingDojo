using Homework7.Lib;
using System;
using Xunit;

namespace Homework7.Test
{
    public class Homework07Test
    {
        [Theory]
        [InlineData("again and hello makes perfect practice world", "hello world and practice makes perfect and hello world again")]
        public void InputASetOfStringItMustRemoveDuplicateStringAndSorting(string expected, string inputString)
        {
            var svc = new Homework07();
            var actual = svc.RemoveAndSortTextByAlphabetical(inputString);
            Assert.Equal(expected,actual);
        }
    }
}
