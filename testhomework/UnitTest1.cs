using System;
using homework;
using Xunit;

namespace testhomework
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("ta,at,oa","at,oa,ta")]
        public void Test1(string text, string excepted)
        {
            var word = new alphabetically();
           var result = word.SortByAlphabetical(text);
           Assert.Equal(excepted, result);

        }
    }
}
