using System;
using System.Text;
using System.Linq;

namespace Homework01.Lib
{
    public class TextSorting : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            var strSplit = text.Split(',');
            Array.Sort(strSplit);
            return string.Join(",", strSplit);
        }
    }
}
