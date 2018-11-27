using System;
using Xunit;

namespace homework11.Test
{
    public class GetReadWordOfNumberTest
    {
        [Theory(DisplayName="ตัวเลขหลักหน่วย")]
        [InlineData(0,"ศูนย์")]
        [InlineData(1,"หนึ่ง")]
        [InlineData(2,"สอง")]
        [InlineData(3,"สาม")]
        [InlineData(4,"สี่")]
        [InlineData(5,"ห้า")]
        [InlineData(6,"หก")]
        [InlineData(7,"เจ็ด")]
        [InlineData(8,"แปด")]
        [InlineData(9,"เก้า")]
        public void CheckGetReadWordOfNumber1Digit(int inPutNumber,string expected)
        {
            var sut = new GetReadWordOfNumberLogic();
            var result = sut.GetReadWordOfNumber(inPutNumber);
            Assert.Equal(result,expected);
        }
       
        [Theory(DisplayName="ตัวเลขหลักสิบ")]
        [InlineData(10,"สิบ")]
        [InlineData(20,"ยี่สิบ")]
        [InlineData(30,"สามสิบ")]
        [InlineData(40,"สี่สิบ")]
        [InlineData(50,"ห้าสิบ")]
        [InlineData(60,"หกสิบ")]
        [InlineData(70,"เจ็ดสิบ")]
        [InlineData(80,"แปดสิบ")]
        [InlineData(90,"เก้าสิบ")]
        public void CheckGetReadWordOfNumber2Digit(int inPutNumber,string expected)
        {
            var sut = new GetReadWordOfNumberLogic();
            var result = sut.GetReadWordOfNumber(inPutNumber);
            Assert.Equal(result,expected);
        }
    }
}
