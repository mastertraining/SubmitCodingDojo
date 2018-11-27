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
        [InlineData(17, "สิบเจ็ด")]
        [InlineData(18, "สิบแปด")]
        [InlineData(19, "สิบเก้า")]
        [InlineData(20, "ยี่สิบ")]
        [InlineData(21, "ยี่สิบเอ็ด")]
        [InlineData(22, "ยี่สิบสอง")]
        [InlineData(30, "สามสิบ")]
        [InlineData(31, "สามสิบเอ็ด")]
        [InlineData(32, "สามสิบสอง")]
        public void Test1(int number, string excepted)
        {
            var sut = new logic();
            var result = sut.GetReadWordOfNumber(number);
            Assert.Equal(excepted, result);

        }
    }
}
