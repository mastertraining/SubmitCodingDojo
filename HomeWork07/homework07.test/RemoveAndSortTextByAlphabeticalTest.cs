using System;
using homework07.lib;
using Xunit;

namespace homework07.test
{
    public class RemoveAndSortTextByAlphabeticalTest
    {
        [Theory(DisplayName = "RemoveAndSortTextByAlphabetical is success")]
        [InlineData("hello", "hello")]
        [InlineData(" hello ", "hello")]
        [InlineData("hello world hello world again", "again hello world")]
        [InlineData("hello world and practice makes perfect and hello world again", "again and hello makes perfect practice world")]
        [InlineData("hello world makess and practice makes perfect and hello world again makess", "again and hello makes makess perfect practice world")]
        public void RemoveAndSortTextByAlphabetical_Success(string text, string expected)
        {
            var control = new Homework07();
            var result = control.RemoveAndSortTextByAlphabetical(text);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "RemoveAndSortTextByAlphabetical is fail")]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void RemoveAndSortTextByAlphabetical_Fail(string text)
        {
            var control = new Homework07();
            var result = control.RemoveAndSortTextByAlphabetical(text);
            Assert.Empty(result);
        }
    }
}
