using System;
using hw3ClassLib;
using Xunit;

namespace hw3Test
{
    public class TestHomework03
    {
        [Theory]
        [InlineData(new string[] {"Hello world","Practice makes perfect"}, new string[]{"HELLO WORLD","PRACTICE MAKES PERFECT"})]
        public void Test(string[] text, string[] expected)
        {
            {
                var sut = new Homework03();
                var result = sut.CapitalizedText(text);
                Assert.Equal(expected, result);
            }
        }
    }
}
