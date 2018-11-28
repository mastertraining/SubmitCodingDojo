using System;
using capitalized.lib;
using Xunit;
using System.Collections.Generic;

namespace capitalized.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IHomework03 sut = new Homework03();
            var actual = sut.CapitalizedText(new List<string> { "Hello world", "Practice makes perfect" });
            var expected = new List<string> { "HELLO WORLD", "PRACTICE MAKES PERFECT" };
            Assert.Equal(expected,actual);
        }
    }
}
