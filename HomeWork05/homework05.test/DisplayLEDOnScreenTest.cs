using System;
using Xunit;
using homework05.lib;
using System.Collections.Generic;

namespace homework05.test
{
    public class DisplayLEDOnScreenTest
    {
        [Theory(DisplayName = "DisplayLEDOnScreen is success each number")]
        [InlineData("1", "[!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A")]
        [InlineData("2", "[ ] [!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A")]
        [InlineData("3", "[ ] [ ] [!] [ ] [ ] [ ] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A")]
        [InlineData("4", "[ ] [ ] [ ] [!] [ ] [ ] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A")]
        [InlineData("5", "[ ] [ ] [ ] [ ] [!] [ ] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A")]
        [InlineData("6", "[ ] [ ] [ ] [ ] [ ] [!] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A")]
        [InlineData("7", "[ ] [ ] [ ] [ ] [ ] [ ] [!] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A")]
        [InlineData("8", "[ ] [ ] [ ] [ ] [ ] [ ] [ ] [!] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A")]
        [InlineData("9", "[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [!] [ ]\r\n 1   2   3   4   5   6   7   8   9   A")]
        [InlineData("A", "[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [!]\r\n 1   2   3   4   5   6   7   8   9   A")]
        [InlineData("a", "[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [!]\r\n 1   2   3   4   5   6   7   8   9   A")]
        public void DisplayLEDOnScreen_Success(string ledNo, string expected)
        {
            var ledControl = new Homework05();
            var result = ledControl.DisplayLEDOnScreen(ledNo);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "DisplayLEDOnScreen is fail")]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("0")]
        [InlineData("11")]
        [InlineData("b")]
        public void DisplayLEDOnScreen_Fail(string ledNo)
        {
            var ledControl = new Homework05();
            var result = ledControl.DisplayLEDOnScreen(ledNo);
            var expected = $"[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]{Environment.NewLine} 1   2   3   4   5   6   7   8   9   A";
            Assert.Equal(expected, result);
        }
    }
}
