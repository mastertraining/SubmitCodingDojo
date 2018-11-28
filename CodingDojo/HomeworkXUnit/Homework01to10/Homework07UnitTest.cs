﻿using FluentAssertions;
using Homework07;
using Xunit;

namespace HomeworkXUnit
{
    public class Homework07UnitTest
    {
        private IHomework07 IHW;

        public Homework07UnitTest() => IHW = new Homework07.Homework07();

        [Theory]
        [InlineData("hello world and practice makes perfect and hello world again", "again and hello makes perfect practice world")]
        public void RemoveAndSortTextByAlphabeticalShouldWork(string text, string expected)
        {
            var result = IHW.RemoveAndSortTextByAlphabetical(text);
            result.Should().Be(expected);
        }
    }
}
