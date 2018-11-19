using System;
using System.Collections.Generic;
using hw5ClassLib;
using Xunit;

namespace hw5Test
{
    public class TestHomework05
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void Test(string ledNo, string expected)
        {
            var ledControl = new Homework05();
            var result = ledControl.DisplayLEDOnScreen(ledNo);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] {"1","[!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A"},
            new object[] {"2","[ ] [!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A"},
            new object[] {"3","[ ] [ ] [!] [ ] [ ] [ ] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A"},
            new object[] {"4","[ ] [ ] [ ] [!] [ ] [ ] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A"},
            new object[] {"5","[ ] [ ] [ ] [ ] [!] [ ] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A"},
            new object[] {"6","[ ] [ ] [ ] [ ] [ ] [!] [ ] [ ] [ ] [ ]\r\n 1   2   3   4   5   6   7   8   9   A"},

        };
    }
}
