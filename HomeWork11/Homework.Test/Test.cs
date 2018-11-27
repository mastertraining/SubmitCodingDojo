using System;
using System.Collections.Generic;
using Homework.ConsoleApp;
using Xunit;
using System.Linq;
using FluentAssertions;

namespace Homework.Test
{
    public class Test
    {
        [Theory]
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
        [InlineData(10, "สิบ")]
        [InlineData(11, "สิบเอ็ด")]
        [InlineData(20, "ยี่สิบ")]
        [InlineData(21, "ยี่สิบเอ็ด")]
        [InlineData(101, "หนึ่งร้อยเอ็ด")]
        [InlineData(121, "หนึ่งร้อยยี่สิบเอ็ด")]
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
        [InlineData(9999999, "เก้าล้านเก้าแสนเก้าหมื่นเก้าพันเก้าร้อยเก้าสิบเก้า")]
        public void TestGetReadWordOfNumber(int number, string expectWord)
        {
            var sut = new Homework11();
            var result = sut.GetReadWordOfNumber(number);
            Assert.Equal(expectWord, result);
        }
    }
}