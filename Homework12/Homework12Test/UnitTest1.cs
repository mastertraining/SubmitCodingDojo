using System;
using Homework12classlib;
using Xunit;

namespace Homework12Test
{
    public class UnitTest1
    {
        [Fact]
        public void FirstDuplicate()
        {
            var sut = new Logic();
            var result = sut.FirstDuplicateCharactor("1232");
            Assert.Equal('2',result);
        }

        [Fact]
        public void FirstDuplicateAlphabet()
        {
            var sut = new Logic();
            var result = sut.FirstDuplicateCharactor("AaBbCcc");
            Assert.Equal('c',result);
        }

        [Fact]
        public void FirstDuplicatespace()
        {
            var sut = new Logic();
            var result = sut.FirstDuplicateCharactor("A BbC c");
            Assert.Equal(' ',result);
        }

         [Fact]
        public void FirstNotDuplicatespace()
        {
            var sut = new Logic();
            var result = sut.FirstNotDuplicateCharactor("23123");
            Assert.Equal('1',result);
        }

         [Fact]
        public void FirstNotDuplicatespacenull()
        {
            var sut = new Logic();
            var result = sut.FirstNotDuplicateCharactor("231231");
            Assert.Equal('-',result);
        }
    }
}
