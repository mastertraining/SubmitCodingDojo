using System;
using Xunit;

namespace homework11.Test
{
    public class GetReadWordOfNumberTest
    {
        [Theory]
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
    }
}
