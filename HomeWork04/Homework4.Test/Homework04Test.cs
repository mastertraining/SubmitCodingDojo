using System;
using Xunit;

namespace Homework4.Test
{
    public class Homework04Test
    {
        [Theory]
        [InlineData("1010", "0100,0011,1010,1001")]
        [InlineData("1111,1010", "0100,1111,1010,1000")]
        public void InputStringThatConstraintsBase2NumberItMustReturnValuesThatCanDivineBy5(string expected, string inpusString)
        {
            var hw4Svc = new Lib.Homework04();
            var actual = hw4Svc.GetDivisibleBy5Text(inpusString);
            Assert.Equal(expected,actual);
        }
    }
}
