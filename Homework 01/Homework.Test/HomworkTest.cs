using System;
using Homework.Lib;
using Xunit;

namespace Homework.Test
{
    public class HomworkTest
    {
        [Theory]
        [InlineData("without,hello,bag,world", "bag,hello,without,world")]
        [InlineData("SorrY,Pass,Fail,Skip","Fail,Pass,Skip,SorrY")]
        public void StringToArray(string input, string output)
        {
            var sut = new Sort();
            var result = sut.SortByAlphabetical(input);
            Assert.Equal(output,result);
        }
    }
}
