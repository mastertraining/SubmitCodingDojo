using System;
using lib;
using Xunit;

namespace sorting.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ITextSorting sut = new homework01();
            var actual = sut.SortByAlphabetical("without,hello,bag,world");
            var expected = "bag,hello,without,world";
            Assert.Equal(expected,actual);
        }
    }
}
