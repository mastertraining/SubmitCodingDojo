using System;
using homework11class;
using Xunit;

namespace homework11Test
{
    public class UnitTest1
    {
        [Theory (DisplayName="เลขหนึ่งหลัก")]
        [InlineData (1,"หนึ่ง")]
        public void onedigit(int number, string expected)
        {
            var sut = new Logic();
            var result = sut.GetReadWordOfNumber(number);
            Assert.Equal(expected, result);
        }
    }
}
