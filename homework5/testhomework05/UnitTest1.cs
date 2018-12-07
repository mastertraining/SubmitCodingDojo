using System;
using homework05;
using Xunit;

namespace testhomework05
{
    public class UnitTest1
    {
        [Theory]
        [InlineData()]
        public void Test1(string ledNo, string excepted)
        {
           var sut = new logicDisplayLEDOnScreen();
           var result = sut.DisplayLEDOnScreen(ledNo);
           Assert.Equal(excepted, result);

        }
    }
}
