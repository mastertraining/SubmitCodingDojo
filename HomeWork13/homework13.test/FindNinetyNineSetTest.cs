using System;
using System.Collections.Generic;
using System.Linq;
using homework13.lib;
using Xunit;

namespace homework13.test
{
    public class FindNinetyNineSetTest
    {
        [Fact(DisplayName = "Find ninety nine set with correct input, system should return equal itself set(s)")]
        public void FindNinetyNineSet_CorrectInput()
        {
            var finder = new FinderNinetyNineSet();
            var numbers = new List<int> { 000099, 009900, 990000, 990999, 919909, 999799 };
            var result = finder.Homework13(numbers);
            var expectedAmount = 6;
            Assert.Equal(expectedAmount, result);
        }

        [Fact(DisplayName = "Find ninety nine set with wrong input, system should return zero set")]
        public void FindNinetyNineSet_WrongInput()
        {
            var finder = new FinderNinetyNineSet();
            var numbers = new List<int> { 000000, 000999, 009990, 099900, 999000, 999999 };
            var result = finder.Homework13(numbers);
            var expectedAmount = 0;
            Assert.Equal(expectedAmount, result);
        }

        [Fact(DisplayName = "Find ninety nine set with 0-999999 input, system should return 42057 sets")]
        public void FindNinetyNineSet_StartZeroToMaximum()
        {
            var finder = new FinderNinetyNineSet();
            var numbers = Enumerable.Range(0, 999999);
            var result = finder.Homework13(numbers);
            var expectedAmount = 42057;
            Assert.Equal(expectedAmount, result);
        }
    }
}
