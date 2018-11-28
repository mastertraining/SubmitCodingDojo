﻿using FluentAssertions;
using Homework05;
using System;
using System.Collections.Generic;
using Xunit;

namespace HomeworkXUnit
{
    public class Homework05UnitTest
    {
        private IHomework05 IHW;
        public Homework05UnitTest() => IHW = new Homework05.Homework05();

        [Theory]
        [MemberData(nameof(GetDisplayLEDOnScreenCase))]
        public void DisplayLEDOnScreenShouldWork(string[] ledNo, string expected)
        {
            var result = string.Empty;
            foreach (var No in ledNo) result = IHW.DisplayLEDOnScreen(No);
            result.Should().Be(expected);
        }

        public static IEnumerable<object[]> GetDisplayLEDOnScreenCase = new List<object[]>
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
    }
}
