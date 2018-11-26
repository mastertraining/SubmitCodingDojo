using System;
using System.Collections.Generic;
using System.Linq;

namespace TextMultiplier.Lib
{
    public class Homework02 : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            List<string> numbers = text.Split(',').ToList();
            List<int> textMultiplier = new List<int>();
            numbers.ForEach(it => textMultiplier.Add(int.Parse(it) * 11));

            List<string> result = new List<string>();
            textMultiplier.ForEach(it => result.Add(string.Format("\n\t{0}", it)));

            var ans = string.Join(",", result);
            return string.Format("[{0}\n]", ans);
        }
    }
}
