using System;
using System.Collections.Generic;
using homework3;
using Xunit;

namespace testhomework3
{

    public class homeworktest3
    {
        [Theory]
        [InlineData("u","U")]
        public void Test1(IEnumerable<string> text, IEnumerable<string> excepted)
        {
            var upper = new workup();
            var result = upper.CapitalizedText(text);
            Assert.Equal(excepted, result);

        }
    }
}