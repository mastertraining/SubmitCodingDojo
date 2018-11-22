using FluentAssertions;
using Homework_04;
using Xunit;

namespace HomeworkXUnit
{
    public class Homework04UnitTest
    {
        private IHomework04 IHW;
        public Homework04UnitTest() => IHW = new Homework04();

        [Theory]
        [InlineData("0100,0011,1010,1001", "1010")]
        public void GetDivisibleBy5TextShouldWork(string text, string expected)
        {
            var result = IHW.GetDivisibleBy5Text(text);
            result.Should().Be(expected);
        }
    }
}
