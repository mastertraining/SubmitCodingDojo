using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework13.Lib
{
    public class Homework13 : IHomework13
    {
        public int Get99NumberCount(IEnumerable<int> numbers)
        {
            var result = 0;
            var splitter = Enumerable.Range(0, 9).Select(it => it.ToString()).ToArray();

            foreach (var item in numbers)
            {
                var has99InNumber = item.ToString().Split(splitter, StringSplitOptions.None).Contains("99");
                if (has99InNumber) result++;
            }

            return result;
        }

        public int Get99NumberForeach0To999999()
        {
            var list = Enumerable.Range(0, 100000);
            var result = Get99NumberCount(list);
            return result;
        }
    }
}
