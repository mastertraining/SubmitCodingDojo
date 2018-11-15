using Homework4.Lib.Contract;
using System;
using System.Linq;

namespace Homework4.Lib
{
    public class Homework04 : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            var numberThatCanDivine5 = text.Split(',').Where(it => Convert.ToInt32(it, 2) % 5 == 0);
            return string.Join(',', numberThatCanDivine5);
        }
    }
}
