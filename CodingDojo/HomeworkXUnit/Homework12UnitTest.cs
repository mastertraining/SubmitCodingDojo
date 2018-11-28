using System;
using System.Collections.Generic;
using System.Text;
using Homework12;
using Xunit;
using FluentAssertions;

namespace HomeworkXUnit
{
    public class Homework12UnitTest
    {
        public IHomework12 IHW;
        public Homework12UnitTest() => IHW = new Homework12.Homework12();

        [Theory]
        [InlineData("ZXCVBNMASDFGHJ", '-')]
        [InlineData("ZXCVBNZXCVBMASDFGHJMASDFGHJ", 'Z')]
        [InlineData("ZXCZXCVBNMASDFGHJVBNMASZXCVBNMASDFGHJDFGHJ", 'Z')]
        public void FirstDuplicateCharactorShouldWork(string text, char expected)
        {
            var result = IHW.FirstDuplicateCharactor(text);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("ZXCVBNMASDFGHJ", 'Z')]
        [InlineData("ZXCVBNZXCVBMASDFGHJMASDFGHJ", 'N')]
        [InlineData("ZXCZXCVBNMASDFGHJVBNMASZXCVBNMASDFGHJDFGHJ",'-')]
        public void FirstNotDuplicateCharactorShouldWork(string text, char expected)
        {
            var result = IHW.FirstNotDuplicateCharactor(text);
            result.Should().Be(expected);
        }
    }
}
