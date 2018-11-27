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

        [Theory(DisplayName = "เลขสองหลักลงท้ายที่สิบ")]
        [InlineData(10, "สิบ")]
        [InlineData(20, "ยี่สิบ")]
        [InlineData(30, "สามสิบ")]
        [InlineData(40, "สี่สิบ")]
        [InlineData(50, "ห้าสิบ")]
        [InlineData(60, "หกสิบ")]
        [InlineData(70, "เจ็ดสิบ")]
        [InlineData(80, "แปดสิบ")]
        [InlineData(90, "เก้าสิบ")]
        public void twodigit(int number, string expected)
        {
            var sut = new Logic();
            var result = sut.GetReadWordOfNumber(number);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "เลขสองหลักลงท้าย2-9")]
        [InlineData(11, "สิบเอ็ด")]
        [InlineData(12, "สิบสอง")]
        [InlineData(13, "สิบสาม")]
        [InlineData(14, "สิบสี่")]
        [InlineData(15, "สิบห้า")]
        [InlineData(16, "สิบหก")]
        [InlineData(17, "สิบเจ็ด")]
        [InlineData(18, "สิบแปด")]
        [InlineData(19, "สิบเก้า")]
        [InlineData(20, "ยี่สิบ")]
        [InlineData(21, "ยี่สิบเอ็ด")]
        [InlineData(22, "ยี่สิบสอง")]
        [InlineData(23, "ยี่สิบสาม")]
        [InlineData(24, "ยี่สิบสี่")]
        [InlineData(25, "ยี่สิบห้า")]
        [InlineData(26, "ยี่สิบหก")]
        [InlineData(27, "ยี่สิบเจ็ด")]
        [InlineData(28, "ยี่สิบแปด")]
        [InlineData(29, "ยี่สิบเก้า")]
        [InlineData(30, "สามสิบ")]
        [InlineData(31, "สามสิบเอ็ด")]
        [InlineData(32, "สามสิบสอง")]
        [InlineData(33, "สามสิบสาม")]
        [InlineData(34, "สามสิบสี่")]
        [InlineData(35, "สามสิบห้า")]
        [InlineData(36, "สามสิบหก")]
        [InlineData(37, "สามสิบเจ็ด")]
        [InlineData(38, "สามสิบแปด")]
        [InlineData(39, "สามสิบเก้า")]
        public void twodigit2_9(int number, string expected)
        {
            var sut = new Logic();
            var result = sut.GetReadWordOfNumber(number);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "เลขสามหลักลงท้ายที่ศูนย์")]
        [InlineData(100, "หนึ่งร้อย")]
        [InlineData(200, "สองร้อย")]
        [InlineData(300, "สามร้อย")]
        [InlineData(400, "สี่ร้อย")]
        [InlineData(500, "ห้าร้อย")]
        [InlineData(600, "หกร้อย")]
        [InlineData(700, "เจ็ดร้อย")]
        [InlineData(800, "แปดร้อย")]
        [InlineData(900, "เก้าร้อย")]
        [InlineData(205, "สองร้อยห้า")]
        [InlineData(126, "หนึ่งร้อยยี่สิบหก")]
        [InlineData(201, "สองร้อยหนึ่ง")]

        public void threedigit(int number, string expected)
        {
            var sut = new Logic();
            var result = sut.GetReadWordOfNumber(number);
            Assert.Equal(expected, result);
        }

    }
}
