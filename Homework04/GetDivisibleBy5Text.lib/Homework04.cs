using System;
using System.Collections.Generic;
using System.Linq;

namespace GetDivisibleBy5Text.lib
{
    public class Homework04 : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            List<int> stringbinarynumbers = text.Split(',').Select(it => Convert.ToInt32(it,2)).ToList();
            var divisibleBy5 = stringbinarynumbers.Where(it => it % 5 == 0).Select(it => Convert.ToString(it,2)).ToList();
            return string.Join(",",divisibleBy5);
        }
    }
}
