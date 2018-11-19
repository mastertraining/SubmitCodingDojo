using Homework5.Lib;
using System;
using Xunit;

namespace Homework5.Test
{
    public class Homework05Test
    {
        [Theory]
        [InlineData(
@"[ ] [ ] [ ] [!] [ ] [ ] [ ] [ ] [ ] [ ]
 1   2   3   4   5   6   7   8   9   A",
new bool[] {false, false, false, false, false, false, false, false, false, false },
"4"
                    )]
        [InlineData(
@"[ ] [ ] [ ] [!] [ ] [ ] [ ] [ ] [ ] [!]
 1   2   3   4   5   6   7   8   9   A",
new bool[] { false, false, false, true, false, false, false, false, false, false },
"A"
                    )]
        [InlineData(
@"[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [!]
 1   2   3   4   5   6   7   8   9   A",
new bool[] { false, false, false, true, false, false, false, false, false, true },
"4"
                    )]

        public void InputLEDWithStringNumberItMustReturnLEDDisplay(string expected, bool[] currentSwitches, string ledSelect)
        {
            var svc = new Homework05();
            svc.Switches = currentSwitches;
            var actual = svc.DisplayLEDOnScreen(ledSelect);
            Assert.Equal(expected,actual);
        }
    }
}
