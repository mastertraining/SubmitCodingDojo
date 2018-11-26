using System;
using Xunit;
using homework11.lib;

namespace homework11.test
{
    public class GetReadWordOfNumberTest
    {
        [Theory(DisplayName = "Get read word of number correctly")]
        [InlineData(0, "ศูนย์")]
        [InlineData(100, "หนึ่งร้อย")]
        [InlineData(150, "หนึ่งร้อยห้าสิบ")]
        [InlineData(153, "หนึ่งร้อยห้าสิบสาม")]
        [InlineData(571, "ห้าร้อยเจ็ดสิบเอ็ด")]
        [InlineData(3234, "สามพันสองร้อยสามสิบสี่")]
        [InlineData(7302, "เจ็ดพันสามร้อยสอง")]
        [InlineData(5045, "ห้าพันสี่สิบห้า")]
        [InlineData(73000, "เจ็ดหมื่นสามพัน")]
        [InlineData(64327, "หกหมื่นสี่พันสามร้อยยี่สิบเจ็ด")]
        [InlineData(620000, "หกแสนสองหมื่น")]
        [InlineData(876530, "แปดแสนเจ็ดหมื่นหกพันห้าร้อยสามสิบ")]
        [InlineData(1234567, "หนึ่งล้านสองแสนสามหมื่นสี่พันห้าร้อยหกสิบเจ็ด")]
        [InlineData(5800345, "ห้าล้านแปดแสนสามร้อยสี่สิบห้า")]
        [InlineData(15800345, "สิบห้าล้านแปดแสนสามร้อยสี่สิบห้า")]
        [InlineData(1234567898, "หนึ่งพันสองร้อยสามสิบสี่ล้านห้าแสนหกหมื่นเจ็ดพันแปดร้อยเก้าสิบแปด")]
        public void GetReadWordOfNumber_Correctly(int number, string expectedResult)
        {
            var reader = new Homework11();
            var result = reader.GetReadWordOfNumber(number);
            Assert.Equal(expectedResult, result);
        }


        [Theory(DisplayName = "Get read word of number wrong")]
        [InlineData(-1)]
        public void GetReadWordOfNumber_InCorrectly(int number)
        {
            var reader = new Homework11();
            var result = reader.GetReadWordOfNumber(number);
            Assert.Empty(result);
        }
    }
}
