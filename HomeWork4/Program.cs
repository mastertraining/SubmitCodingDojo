using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork4
{
    class Program : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            List<int> divisibleByFive = new List<int>{};
            int[] arrInt = Array.ConvertAll(text.Split(','), x => Convert.ToInt32(x, 2));
            foreach(var val in arrInt) if (val % 5 == 0) divisibleByFive.Add(val);
            return string.Join(", ", divisibleByFive.Select(x => Convert.ToString(x, 2)));
        }
    }
}