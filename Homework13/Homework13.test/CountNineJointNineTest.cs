using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;

namespace Homework13.test
{
    public class CountNineJointNineTest
    {
        public static IEnumerable<object[]> DataTest =>
        new List<object[]>
        {
           new object[] { new int[] { 990990, 999990, 900099, 990099, 999999 }, 3},
           new object[] { new int[] { 919909, 999990, 990099, 990999, 780990 }, 4},
        };

        [Theory]
        [InlineData(990990, true)]
        [InlineData(999990, false)]
        [InlineData(900099, true)]
        [InlineData(990099, true)]
        [InlineData(999999, false)]
        public void IsNineJointNine(int input, bool expected)
        {
            var sut = new Homework13();
            var actual = sut.IsNineNineCheck(input);
            actual.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(DataTest))]
        public void TestNumberSet(int[] input, int expected)
        {
            IHomework13 sut = new Homework13();
            var actual = sut.Homework13(input);
            actual.Should().Be(expected);
        }
    }
}
