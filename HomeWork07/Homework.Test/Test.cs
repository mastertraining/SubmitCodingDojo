using System;
using System.Collections.Generic;
using Homework.ConsoleApp;
using Xunit;

namespace Homework.Test
{
    public class Test
    {
        [Theory]
        [InlineData("hello world and practice makes perfect and hello world again", "again and hello makes perfect practice world")]
        [InlineData("hello world and practice makes and hello world again", "again and hello makes practice world")]
        [InlineData("hello world practice makes perfect and hello world again", "again and hello makes perfect practice world")]
        public void TestSortByAlphabetical(string text, string expectText)
        {
            var sut = new Homework07();
            var result = sut.RemoveAndSortTextByAlphabetical(text);
            Assert.Equal(expectText, result);
        }
    }
}
