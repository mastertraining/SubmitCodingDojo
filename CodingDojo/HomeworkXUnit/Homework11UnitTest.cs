using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Homework11;

namespace HomeworkXUnit
{
    public class Homework11UnitTest
    {
        public IHomework11 IHW;
        public Homework11UnitTest() => IHW = new Homework11.Homework11();

        [Theory]
        [InlineData(0, "ศูนย์")]
        [InlineData(1, "หนึ่ง")]
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
        [InlineData(15000001, "สิบห้าล้านเอ็ด")]
        public void GetReadWordOfNumber(int number, string expected)
        {
            var result = IHW.GetReadWordOfNumber(number);
            result.Should().Be(expected);
        }
    }
}
