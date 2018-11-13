using Homework01.Lib.Contract;
using System;

namespace Homework01.Lib
{
    public class TextSorting : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            var splittedText = text.Split(",");
            Array.Sort(splittedText);
            var result = string.Join(",", splittedText);
            return result;
        }
    }
}
