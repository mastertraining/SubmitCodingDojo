using FluentAssertions;
using Homework_06;
using System;
using System.Collections.Generic;
using Xunit;

namespace HomeworkXUnit
{
    public class Homework06UnitTest
    {
        private IHomework06 IHW;

        public Homework06UnitTest()
        {
            IHW = new Homework06();
        }

        [Theory]
        [MemberData(nameof(DisplayLEDOnScreenCase))]
        public void DisplayLEDOnScreenShouldWork(string[] ledNo, string expected)
        {
            var result = string.Empty;
            foreach (var No in ledNo)
            {
                result = IHW.DisplayLEDOnScreen(No);
            }
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(DisplayLEDOnScreenCase))]
        public void SaveCurrentStateShouldWork(string[] ledNo, string expected)
        {
            var currentState = string.Empty;
            foreach (var No in ledNo)
            {
                currentState = IHW.DisplayLEDOnScreen(No);
            }
            IHW.SaveCurrentState();
            currentState.Should().Be(expected);
            var HW06 = new Homework06();
            var result = HW06.LoadState();
            result.Should().Be(expected);
        }

        public static IEnumerable<object[]> DisplayLEDOnScreenCase = new List<object[]>
        {
            new object[]{
                new string[] {"A"},
                $"[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [!]{Environment.NewLine} 1   2   3   4   5   6   7   8   9   A"
                },
            new object[]{
                new string[] {"4"},
                $"[ ] [ ] [ ] [!] [ ] [ ] [ ] [ ] [ ] [ ]{Environment.NewLine} 1   2   3   4   5   6   7   8   9   A"
                },
            new object[]{
                new string[] {"4", "4"},
                $"[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]{Environment.NewLine} 1   2   3   4   5   6   7   8   9   A"
                },
            new object[]{
                new string[] {"4", "A", "1", "8", "1"},
                $"[ ] [ ] [ ] [!] [ ] [ ] [ ] [!] [ ] [!]{Environment.NewLine} 1   2   3   4   5   6   7   8   9   A"
                }
        };

        public static IEnumerable<object[]> ConfigurationsCase = new List<object[]>
        {
            new object[]{
                new string[] {"A"},"O","C",3,
                $"[C]   [C]   [C]   [C]   [C]   [C]   [C]   [C]   [C]   [O]{Environment.NewLine} 1     2     3     4     5     6     7     8     9     A"
            },
            new object[]{
                new string[] {"4"},"L","D",2,
                $"[D]  [D]  [D]  [L]  [D]  [D]  [D]  [D]  [D]  [D]{Environment.NewLine} 1    2    3    4    5    6    7    8    9    A"
                },
            new object[]{
                new string[] {"4", "4"},"R"," ",1,
                $"[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]{Environment.NewLine} 1   2   3   4   5   6   7   8   9   A"
                },
            new object[]{
                new string[] {"4", "A", "1", "8", "1"}," ",@"\",1,
                $@"[\] [\] [\] [ ] [\] [\] [\] [ ] [\] [ ]{Environment.NewLine} 1   2   3   4   5   6   7   8   9   A"
                }
        };
    }
}
