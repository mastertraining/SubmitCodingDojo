using System;
using System.Linq;
namespace Homework04.Lib
{
    public class DivisibleBy5Text : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            return string.Join(",", 
                   text.Split(',').
                   Where(x => Convert.ToInt32(x, 2) % 5 == 0).ToArray());
        }
    }
}
