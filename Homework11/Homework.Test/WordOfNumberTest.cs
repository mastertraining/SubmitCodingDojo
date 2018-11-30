using System;
using Homework.Lib;
using Xunit;

namespace Homework.Test {
    public class WordOfNumberTest {
        [Theory]
        [InlineData (1231416,"หนึ่งล้านสองแสนสามหมื่นหนึ่งพันสี่ร้อยสิบหก")]
        [InlineData (1231411,"หนึ่งล้านสองแสนสามหมื่นหนึ่งพันสี่ร้อยสิบเอ็ด")]
        [InlineData (1231016,"หนึ่งล้านสองแสนสามหมื่นหนึ่งพันสิบหก")]
        public void WordOfNumberTest1 (int number, string expedted) {
            var sut = new WordOfNumber ();
            var result = sut.GetReadWordOfNumber(number);
            Assert.Equal(result, expedted);
        }
    }
}