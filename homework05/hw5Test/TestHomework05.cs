using System;
using hw5ClassLib;
using Xunit;

namespace hw5Test
{
    public class TestHomework05
    {
        [Theory]
        [InlineData("1", "[!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] \n 1  2  3  4  5  6  7  8  9  A ")]
        // [InlineData("2", "[ ][!][ ][ ][ ][ ][ ][ ][ ][ ]\r\n 1  2  3  4  5  6  7  8  9  A ")]
        // [InlineData("3", "[ ][ ][!][ ][ ][ ][ ][ ][ ][ ]\r\n 1  2  3  4  5  6  7  8  9  A ")]
        // [InlineData("4", "[ ][ ][ ][!][ ][ ][ ][ ][ ][ ]\r\n 1  2  3  4  5  6  7  8  9  A ")]
        // [InlineData("5", "[ ][ ][ ][ ][!][ ][ ][ ][ ][ ]\r\n 1  2  3  4  5  6  7  8  9  A ")]
        // [InlineData("6", "[ ][ ][ ][ ][ ][!][ ][ ][ ][ ]\r\n 1  2  3  4  5  6  7  8  9  A ")]
        // [InlineData("7", "[ ][ ][ ][ ][ ][ ][!][ ][ ][ ]\r\n 1  2  3  4  5  6  7  8  9  A ")]
        public void Test(string ledNo, string expected)
        {
            var ledControl = new Homework05();
            var result = ledControl.DisplayLEDOnScreen(ledNo);
            Assert.Equal(expected, result);
        }
    }
}
