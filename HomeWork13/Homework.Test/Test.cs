using System;
using System.Collections.Generic;
using Homework.ConsoleApp;
using Xunit;
using System.Linq;
using FluentAssertions;

namespace Homework.Test
{
    public class Test
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void TestHomework13(IEnumerable<int> numbers, int expectAmount)
        {
            var sut = new HomeworkTheS();
            var result = sut.Homework13(numbers);
            Assert.Equal(expectAmount, result);
        }

        public static IEnumerable<object[]> GetData = new List<object[]>
        {
            new object[] {
                new List<int>
                {
                    000000, 000099, 009900, 990000,000999, 009990, 099900, 999000,990999, 919909, 999799, 999999,
                },
                6,
            },
            new object[] {
                new List<int>
                {
                    000000, 000999, 009900, 990000, 000999, 009990, 099900, 999000, 990999, 919909, 999799, 999999
                },
                5,
            },
            new object[] {
                new List<int>
                {
                    990990, 000099, 009900, 990000, 000999, 009990, 099900, 999000, 990999, 919909, 999799, 999999
                },
                7,
            },
        };
    }
}