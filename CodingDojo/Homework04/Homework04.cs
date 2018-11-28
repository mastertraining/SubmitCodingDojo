using System;
using System.Linq;

namespace Homework04
{
    public class Homework04 : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            var textArray = text.Split(",");
            if (textArray.Any(it => it.Length > 4))
                return "only accepts a sequence of comma separated 4 digit binary numbers";
            var divisibleBy5List = textArray.Where(it => Convert.ToInt32(it, 2) % 5 == 0);
            return string.Join(",", divisibleBy5List);
        }
    }
}
