using HomeWirk01.lib.Contract;
using System;
using System.Linq;

namespace HomeWork01.lib
{
    public class TextSort : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            var data = text.Split(",");
            var result = data.OrderBy(it => it);
            var xxx = string.Join(",",result);
            return xxx;
        }
    }
}
