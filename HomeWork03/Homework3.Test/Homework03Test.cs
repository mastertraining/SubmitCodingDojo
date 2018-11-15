using System;
using Xunit;

namespace Homework3.Test
{
    public class Homework03Test
    {
        [Theory]
        [InlineData(new string[] { "HELLO WORLD", "PRACTICE MAKES PERFECT" }, new string[] { "Hello world", "Practice makes perfect" })]
        [InlineData(new string[] { "I AM A MAN", "YOU ARE A GIRL" }, new string[] { "I am a man", "You are a girl" })]
        public void InputLowerCaseStringMustReturnUpperCaseString(string[] expected, string[] inputString)
        {
            var hw3Svc = new Lib.Homework03();
            var actual = hw3Svc.CapitalizedText(inputString);
            Assert.Equal(expected,actual);
        }
    }
}
