using System;
using Xunit;

namespace homework11.Test
{
    public class GetReadWordOfNumberTest
    {
        [Theory(DisplayName = "ตัวเลขหลักหน่วย0-9")]
        [InlineData(0, "ศูนย์")]
        [InlineData(1, "หนึ่ง")]
        [InlineData(2, "สอง")]
        [InlineData(3, "สาม")]
        [InlineData(4, "สี่")]
        [InlineData(5, "ห้า")]
        [InlineData(6, "หก")]
        [InlineData(7, "เจ็ด")]
        [InlineData(8, "แปด")]
        [InlineData(9, "เก้า")]
        public void CheckGetReadWordOfNumber1Digit(int inPutNumber, string expected)
        {
            var sut = new GetReadWordOfNumberLogic();
            var result = sut.GetReadWordOfNumber(inPutNumber);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "ตัวเลขหลักสิบทั้งหมด10-90")]
        [InlineData(10, "สิบ")]
        [InlineData(20, "ยี่สิบ")]
        [InlineData(30, "สามสิบ")]
        [InlineData(40, "สี่สิบ")]
        [InlineData(50, "ห้าสิบ")]
        [InlineData(60, "หกสิบ")]
        [InlineData(70, "เจ็ดสิบ")]
        [InlineData(80, "แปดสิบ")]
        [InlineData(90, "เก้าสิบ")]
        public void CheckGetReadWordOfNumber2Digit(int inPutNumber, string expected)
        {
            var sut = new GetReadWordOfNumberLogic();
            var result = sut.GetReadWordOfNumber(inPutNumber);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "ตัวเลขหลักสิบ11-39")]
        [InlineData(11, "สิบเอ็ด")]
        [InlineData(12, "สิบสอง")]
        [InlineData(13, "สิบสาม")]
        [InlineData(14, "สิบสี่")]
        [InlineData(15, "สิบห้า")]
        [InlineData(16, "สิบหก")]
        [InlineData(17, "สิบเจ็ด")]
        [InlineData(18, "สิบแปด")]
        [InlineData(19, "สิบเก้า")]
        [InlineData(21, "ยี่สิบเอ็ด")]
        [InlineData(22, "ยี่สิบสอง")]
        [InlineData(23, "ยี่สิบสาม")]
        [InlineData(24, "ยี่สิบสี่")]
        [InlineData(25, "ยี่สิบห้า")]
        [InlineData(26, "ยี่สิบหก")]
        [InlineData(27, "ยี่สิบเจ็ด")]
        [InlineData(28, "ยี่สิบแปด")]
        [InlineData(29, "ยี่สิบเก้า")]
        [InlineData(31, "สามสิบเอ็ด")]
        [InlineData(32, "สามสิบสอง")]
        [InlineData(33, "สามสิบสาม")]
        [InlineData(34, "สามสิบสี่")]
        [InlineData(35, "สามสิบห้า")]
        [InlineData(36, "สามสิบหก")]
        [InlineData(37, "สามสิบเจ็ด")]
        [InlineData(38, "สามสิบแปด")]
        [InlineData(39, "สามสิบเก้า")]
        public void CheckGetReadWordOfNumber2Digits(int inPutNumber, string expected)
        {
            var sut = new GetReadWordOfNumberLogic();
            var result = sut.GetReadWordOfNumber(inPutNumber);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "ตัวเลขหลักร้อยถึงหลักล้าน")]
        [InlineData(100, "หนึ่งร้อย")]
        [InlineData(200, "สองร้อย")]
        [InlineData(300, "สามร้อย")]
        [InlineData(400, "สี่ร้อย")]
        [InlineData(500, "ห้าร้อย")]
        [InlineData(600, "หกร้อย")]
        [InlineData(700, "เจ็ดร้อย")]
        [InlineData(800, "แปดร้อย")]
        [InlineData(900, "เก้าร้อย")]
        [InlineData(125, "หนึ่งร้อยยี่สิบห้า")]
        [InlineData(205, "สองร้อยห้า")]
        [InlineData(1000, "หนึ่งพัน")]
        [InlineData(10000, "หนึ่งหมื่น")]
        [InlineData(19750, "หนึ่งหมื่นเก้าพันเจ็ดร้อยห้าสิบ")]
        [InlineData(100000, "หนึ่งแสน")]
        [InlineData(102536, "หนึ่งแสนสองพันห้าร้อยสามสิบหก")]
        [InlineData(1000000, "หนึ่งล้าน")]
        [InlineData(1235478, "หนึ่งล้านสองแสนสามหมื่นห้าพันสี่ร้อยเจ็ดสิบแปด")]
        public void CheckGetReadWordOfNumber3Digit(int inPutNumber, string expected)
        {
            var sut = new GetReadWordOfNumberLogic();
            var result = sut.GetReadWordOfNumber(inPutNumber);
            Assert.Equal(expected, result);
        }
    }
}
