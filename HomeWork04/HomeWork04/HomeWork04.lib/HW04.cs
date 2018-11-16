using HomeWork04.lib.Contract;
using System;
using System.Linq;

namespace HomeWork04.lib
{
    public class HW04 : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            string[] data = text.Split(",");
            var Binary = data.Where(it => Convert.ToInt32(it, 2) % 5 == 0);
            string result = string.Join(",", Binary);
            return result;

        }
    }
}
