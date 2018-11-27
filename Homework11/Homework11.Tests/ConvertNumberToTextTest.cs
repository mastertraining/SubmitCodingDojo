using System;
using Xunit;

namespace Homework11.Tests
{
    public class ConvertNumberToTextTest
    {
        [Theory]
        [InlineData(10, "สิบ")]
        [InlineData(11,"สิบเอ็ด")]
        [InlineData(1, "หนึ่ง")]
        [InlineData(0, "ศูนย์")]
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
        public void ConvertNumber10ToText(int input,string expected)
        {
            var sut = new Homework11();
            var actual = sut.GetReadWordOfNumber(input);
            Assert.Equal(expected, actual);
        }
    }
}
