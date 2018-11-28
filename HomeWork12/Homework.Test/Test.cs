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
        [InlineData("AsviaHcLKEjvDJhFjhfd", 'v','A')]
        [InlineData("ZXCVBNMASDFGHJ", '-','Z')]
        [InlineData("ZXCVBNZXCVBMASDFGHJMASDFGHJ", 'Z','N')]
        [InlineData("ZXCZXCVBNMASDFGHJVBNMASZXCVBNMASDFGHJDFGHJ", 'Z','-')]
        public void TestFirstDuplicateCharactor(string text, char expectDCharactor,char expectNDCharactor)
        {
            var sut = new Homework12();
            var DCharactor = sut.FirstDuplicateCharactor(text);
            var NDCharactor = sut.FirstNotDuplicateCharactor(text);
            Assert.Equal(expectDCharactor, DCharactor);
            Assert.Equal(expectNDCharactor, NDCharactor);
        }
    }
}