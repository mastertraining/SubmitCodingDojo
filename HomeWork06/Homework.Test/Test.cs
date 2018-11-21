using System.Collections.Generic;
using FluentAssertions;
using Homework.ConsoleApp;
using Xunit;

namespace Homework.Test
{
    public class Test
    {
        [Theory]
        [MemberData(nameof(GetChangeDisplayLEDOnScreen))]
        public void TestDisplayLEDOnScreen(Dictionary<string, string> oldLED, string ledNo, Dictionary<string, string> expectNewLED)
        {
            var sut = new Homework06();
            sut.LED = oldLED;
            sut.DisplayLEDOnScreen(ledNo);
            sut.LED.Should().BeEquivalentTo(expectNewLED);
        }

        public static IEnumerable<object[]> GetChangeDisplayLEDOnScreen = new List<object[]>
        {
            new object[] {
                new Dictionary<string,string>
                {
                    {"1", "[ ]"},
                    {"2", "[ ]"},
                    {"3", "[ ]"},
                    {"4", "[ ]"},
                    {"5", "[ ]"},
                    {"6", "[ ]"},
                    {"7", "[ ]"},
                    {"8", "[ ]"},
                    {"9", "[ ]"},
                    {"A", "[ ]"}
                },
                "4",
                new Dictionary<string,string>
                {
                    {"1", "[ ]"},
                    {"2", "[ ]"},
                    {"3", "[ ]"},
                    {"4", "[!]"},
                    {"5", "[ ]"},
                    {"6", "[ ]"},
                    {"7", "[ ]"},
                    {"8", "[ ]"},
                    {"9", "[ ]"},
                    {"A", "[ ]"}
                }
            },
            new object[] {
                new Dictionary<string,string>
                {
                    {"1", "[ ]"},
                    {"2", "[ ]"},
                    {"3", "[ ]"},
                    {"4", "[!]"},
                    {"5", "[ ]"},
                    {"6", "[ ]"},
                    {"7", "[ ]"},
                    {"8", "[ ]"},
                    {"9", "[ ]"},
                    {"A", "[ ]"}
                },
                "A",
                new Dictionary<string,string>
                {
                    {"1", "[ ]"},
                    {"2", "[ ]"},
                    {"3", "[ ]"},
                    {"4", "[!]"},
                    {"5", "[ ]"},
                    {"6", "[ ]"},
                    {"7", "[ ]"},
                    {"8", "[ ]"},
                    {"9", "[ ]"},
                    {"A", "[!]"}
                }
            },
            new object[] {
                new Dictionary<string,string>
                {
                    {"1", "[ ]"},
                    {"2", "[ ]"},
                    {"3", "[ ]"},
                    {"4", "[!]"},
                    {"5", "[ ]"},
                    {"6", "[ ]"},
                    {"7", "[ ]"},
                    {"8", "[ ]"},
                    {"9", "[ ]"},
                    {"A", "[!]"}
                },
                "4",
                new Dictionary<string,string>
                {
                    {"1", "[ ]"},
                    {"2", "[ ]"},
                    {"3", "[ ]"},
                    {"4", "[ ]"},
                    {"5", "[ ]"},
                    {"6", "[ ]"},
                    {"7", "[ ]"},
                    {"8", "[ ]"},
                    {"9", "[ ]"},
                    {"A", "[!]"}
                }
            },
            new object[] {
                new Dictionary<string,string>
                {
                    {"1", "[ ]"},
                    {"2", "[ ]"},
                    {"3", "[ ]"},
                    {"4", "[ ]"},
                    {"5", "[ ]"},
                    {"6", "[ ]"},
                    {"7", "[ ]"},
                    {"8", "[ ]"},
                    {"9", "[ ]"},
                    {"A", "[!]"}
                },
                "a",
                new Dictionary<string,string>
                {
                    {"1", "[ ]"},
                    {"2", "[ ]"},
                    {"3", "[ ]"},
                    {"4", "[ ]"},
                    {"5", "[ ]"},
                    {"6", "[ ]"},
                    {"7", "[ ]"},
                    {"8", "[ ]"},
                    {"9", "[ ]"},
                    {"A", "[!]"}
                }
            },
        };
    }
}
