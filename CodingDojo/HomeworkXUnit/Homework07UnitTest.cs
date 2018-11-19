using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HomeworkXUnit
{
    public class Homework07UnitTest
    {
        public Homework07UnitTest()
        {

        }

        [Theory]
        [InlineData("hello world and practice makes perfect and hello world again", "again and hello makes perfect practice world")]
        public void RemoveAndSortTextByAlphabeticalShouldWork(string text, string expected)
        {

        }
    }
}
