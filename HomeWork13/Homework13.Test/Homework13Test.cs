using System;
using Xunit;

namespace Homework13.Test
{
    public class Homework13Test
    {
        [Theory]
        [InlineData(6, new int[] { 000000, 000099, 009900, 990000, 000999, 009990, 099900, 999000, 990999, 919909, 999799, 999999 })]
        [InlineData(7, new int[] { 000000, 000099, 009900, 990000, 000999, 009990, 099900, 999000, 990999, 919909, 999799, 999999, 992993 })]
        public void InputASetOfNumberItMustReturnACountOf99Numbers(int expected, int[] input)
        {
            var sut = new Lib.Homework13();
            var actual = sut.Get99NumberCount(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InputASetOfNumberFrom0To999999ItMustReturnACountOf99Numbers()
        {
            var sut = new Lib.Homework13();
            var actual = sut.Get99NumberForeach0To999999();
            Assert.Equal(42057, actual);
        }
    }
}
