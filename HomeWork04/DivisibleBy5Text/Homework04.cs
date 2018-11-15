using System;
using System.Linq;

namespace DivisibleBy5Text
{
    public class Homework04 : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            var numberList = text.Split(',').Select(it => Convert.ToInt32(it,2)).ToList();
            var numberDivideByFive = numberList.Where(it => it % 5 == 0).Select(it => Convert.ToString(it,2)).ToList();
            return String.Join(",", numberDivideByFive);
        }
    }
}