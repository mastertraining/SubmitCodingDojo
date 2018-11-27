using System;
using hw11;
using Xunit;

namespace testhw11
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(9, "เก้า")]
        [InlineData(10, "สิบ")]
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
        [InlineData(100, "หนึ่งร้อย")]
        [InlineData(125, "หนึ่งร้อยยี่สิบห้า")]
        [InlineData(555, "ห้าร้อยห้าสิบห้า")]
        [InlineData(910, "เก้าร้อยสิบ")]
        [InlineData(1900, "หนึ่งพันเก้าร้อย")]
        [InlineData(1713, "หนึ่งพันเจ็ดร้อยสิบสาม")]
        [InlineData(21711, "สองหมื่นหนึ่งพันเจ็ดร้อยสิบเอ็ด")]
        [InlineData(81713, "แปดหมื่นหนึ่งพันเจ็ดร้อยสิบสาม")]
        [InlineData(100001, "หนึ่งแสนหนึ่ง")]
        




        public void Test1(int number, string excepted)
        {
            var sut = new logic();
            var result = sut.GetReadWordOfNumber(number);
            Assert.Equal(excepted, result);

        }
    }
}
