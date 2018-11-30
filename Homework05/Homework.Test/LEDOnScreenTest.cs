using System;
using Homework.Lib;
using Xunit;

namespace Homework.Test {
    public class LEDOnScreenTest {
        [Theory]
        [InlineData ("4", "[ ] [ ] [ ] [!] [ ] [ ] [ ] [ ] [ ] [ ]")]
        [InlineData ("9", "[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [!] [ ]")]
        public void DisplayLEDOnScreen (string input, string expedted) {
            var sut = new LEDOnScreen ();
            var result = sut.DisplayLEDOnScreen (input);
            Assert.Equal (expedted, result);
        }
    }
}