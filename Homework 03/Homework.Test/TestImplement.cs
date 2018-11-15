using System;
using Homework.Lib;
using Xunit;
using System.Linq;

namespace Homework.Test {
    public class TestImplement {
        [Fact]
        public void RepaceToUper () {
            var sut = new Implement();
            string[] input = new string[]{"SorrY","sORRy"};
            var result = sut.CapitalizedText(input);
            Assert.Equal(new string[]{"SORRY","SORRY"},result);
        }
    }
}