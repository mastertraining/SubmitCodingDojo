using System;
using System.Collections.Generic;
using System.Linq;

namespace hw7ClassLib
{
    public class Homework07 : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var split = text.Split(' ');
            Array.Sort(split);
            var distinct = split.Distinct();
            var sortText = string.Join(" ", distinct);
            return sortText.ToUpper();
        }
    }
}
