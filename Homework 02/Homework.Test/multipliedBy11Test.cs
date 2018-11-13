using System;
using Homework.Lib;
using Xunit;

namespace Homework.Test
{
    public class MultipliedBy11Test
    {
        // [Fact]
        // public void MultipliedBy11()
        // {
        //     var sut = new MultipliedBy11();
        //     var result = sut.X11("34,67,55,33,12,28");
        //     Assert.Equal("374,737,605,363,132,308", result);
        // }

        [Fact]
        public void StringFormat()
        {
            var sut = new MultipliedBy11();
            var result = sut.GetFormattedString("34,67,55,33,12,28");
            Assert.Equal("[/n/t374,/n/t737,/n/t605,/n/t363,/n/t132,/n/t308/n]", result);
        }
    }
}
