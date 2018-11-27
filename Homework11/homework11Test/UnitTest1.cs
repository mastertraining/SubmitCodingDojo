using System;
using homework11class;
using Xunit;

namespace homework11Test
{
    public class UnitTest1
    {
        [Theory (DisplayName="เลขหนึ่งหลัก")]
        [InlineData (1,"หนึ่ง")]
        [InlineData (0,"ศูนย์")]
        [InlineData (8,"แปด")]


        public void onedigit(int number, string expected)
        {
            var sut = new Logic();
            var result = sut.GetReadWordOfNumber(number);
            Assert.Equal(expected, result);
        }

        [Theory (DisplayName="เลขสองหลักลงท้ายที่สิบ")]
        [InlineData (10,"สิบ")]
        [InlineData (20,"ยี่สิบ")]
        [InlineData (80,"แปดสิบ")]


        public void twodigit(int number, string expected)
        {
            var sut = new Logic();
            var result = sut.GetReadWordOfNumber(number);
            Assert.Equal(expected, result);
        }
    }
}
