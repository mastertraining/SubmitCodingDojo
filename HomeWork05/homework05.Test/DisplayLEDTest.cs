using System;
using Xunit;

namespace homework05.Test
{
    public class DisplayLEDTest
    {
        [Theory(DisplayName = "DisplayOnScreen")]
        [InlineData("1", "[!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A\r\n")]
        [InlineData("2", "[ ] [!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A\r\n")]
        [InlineData("3", "[ ] [ ] [!] [ ] [ ] [ ] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A\r\n")]
        [InlineData("4", "[ ] [ ] [ ] [!] [ ] [ ] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A\r\n")]
        [InlineData("5", "[ ] [ ] [ ] [ ] [!] [ ] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A\r\n")]
        [InlineData("6", "[ ] [ ] [ ] [ ] [ ] [!] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A\r\n")]
        [InlineData("7", "[ ] [ ] [ ] [ ] [ ] [ ] [!] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A\r\n")]
        [InlineData("8", "[ ] [ ] [ ] [ ] [ ] [ ] [ ] [!] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A\r\n")]
        [InlineData("9", "[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [!] [ ]\r\n 1   2   3   4   5   6   7   8   9   A\r\n")]
        [InlineData("a", "[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [!]\r\n 1   2   3   4   5   6   7   8   9   A\r\n")]
        [InlineData("A", "[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [!]\r\n 1   2   3   4   5   6   7   8   9   A\r\n")]

        public void CheckResultDisplayLEDOnScreen(string inputString, string expected)
        {
            var sut = new DisplayLEDLogic();
            var result = sut.DisplayLEDOnScreen(inputString);
            Assert.Equal(expected, result);
        }
    }
}
