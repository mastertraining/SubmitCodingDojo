using System;
using static homework01.SortingText;

namespace homework01
{
    public class TextSorting : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            var split = text.Split(',');
            Array.Sort(split);
            var result = string.Join(",",split);
            return result;
        }
    }
}
