using System;
using Xunit;

namespace Homework11.Test
{
    public class Homework11Test
    {
        [Theory]
        [InlineData("ศูนย์", 0)]
        [InlineData("หนึ่งร้อยห้าสิบสาม", 153)]
        [InlineData("ห้าร้อยเจ็ดสิบเอ็ด", 571)]
        [InlineData("แปดแสนเจ็ดหมื่นหกพันห้าร้อยสามสิบ", 876530)]
        [InlineData("หนึ่งล้านสองแสนสามหมื่นสี่พันห้าร้อยหกสิบเจ็ด", 1234567)]
        public void GiveANumberItMustReturnAReadingOfThatNumber(string expexted, int inputNumber)
        {
            var svc = new Lib.Homework11();
            var actual = svc.GetReadWordOfNumber(inputNumber);
            Assert.Equal(expexted, actual);
        }
    }
}
