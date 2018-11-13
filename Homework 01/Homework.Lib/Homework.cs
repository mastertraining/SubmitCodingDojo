using System;
using System.Linq;

namespace Homework.Lib
{
    public class Sort : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            var split = text.Split(',');
            var sort = split.OrderBy(it => it).ToArray();
            var result = String.Join(",",sort);
            return result;
        }
    }
}
