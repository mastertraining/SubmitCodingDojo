using System;
using homework11class;
using Xunit;

namespace homework11Test
{
    public class UnitTest1
    {
        [Theory(DisplayName = "เลขหนึ่งหลัก")]
        [InlineData(1, "หนึ่ง")]
        [InlineData(0, "ศูนย์")]
        [InlineData(8, "แปด")]


        public void onedigit(int number, string expected)
        {
            var sut = new Logic();
            var result = sut.GetReadWordOfNumber(number);
            Assert.Equal(expected, result);
        }

        // [Theory(DisplayName = "เลขสองหลักลงท้ายที่สิบ")]
        // // [InlineData(10, "สิบ")]
        // [InlineData(20, "ยี่สิบ")]
        // [InlineData(30, "สามสิบ")]
        // [InlineData(40, "สี่สิบ")]
        // [InlineData(50, "ห้าสิบ")]
        // [InlineData(60, "หกสิบ")]
        // [InlineData(70, "เจ็ดสิบ")]
        // [InlineData(80, "แปดสิบ")]
        // [InlineData(90, "เก้าสิบ")]



        // public void twodigit(int number, string expected)
        // {
        //     var sut = new Logic();
        //     var result = sut.GetReadWordOfNumber(number);
        //     Assert.Equal(expected, result);
        // }

        [Theory(DisplayName = "เลขสองหลักลงท้าย2-9")]
        [InlineData(12, "สิบสอง")]
        [InlineData(13, "สิบสาม")]
        [InlineData(14, "สิบสี่")]
        [InlineData(15, "สิบห้า")]
        [InlineData(16, "สิบหก")]
        [InlineData(17, "สิบเจ็ด")]
        [InlineData(18, "สิบแปด")]
        [InlineData(19, "สิบเก้า")]
       



        public void twodigit2_9(int number, string expected)
        {
            var sut = new Logic();
            var result = sut.GetReadWordOfNumber(number);
            Assert.Equal(expected, result);
        }


    }
}
