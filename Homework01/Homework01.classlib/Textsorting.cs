using System;
using System.Linq;
using System.Text;

namespace Homework01.classlib
{
    public class Textsorting : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            var substring = text.Split(',');
            Array.Sort(substring);
            return String.Join(",", substring);
        }
    }
}