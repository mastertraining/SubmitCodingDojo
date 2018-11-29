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
        [InlineData("AsviaHcLKEjvDJhFjhfd", 'v')]
        [InlineData("ZXCVBNMASDFGHJ", '-')]
        [InlineData("ZXCVBNZXCVBMASDFGHJMASDFGHJ", 'Z')]
        [InlineData("ZXCZXCVBNMASDFGHJVBNMASZXCVBNMASDFGHJDFGHJ", 'Z')]
        public void TestFirstDuplicateCharactor(string text, char expectDCharactor)
        {
            var sut = new Homework12();
            var DCharactor = sut.FirstDuplicateCharactor(text);
            Assert.Equal(expectDCharactor, DCharactor);
        }

        [Theory]
        [InlineData("AsviaHcLKEjvDJhFjhfd", 'A')]
        [InlineData("ZXCVBNMASDFGHJ", 'Z')]
        [InlineData("ZXCVBNZXCVBMASDFGHJMASDFGHJ", 'N')]
        [InlineData("ZXCZXCVBNMASDFGHJVBNMASZXCVBNMASDFGHJDFGHJ", '-')]
        public void TestFirstNotDuplicateCharactor(string text, char expectNDCharactor)
        {
            var sut = new Homework12();
            var NDCharactor = sut.FirstNotDuplicateCharactor(text);
            Assert.Equal(expectNDCharactor, NDCharactor);
        }
    }
}