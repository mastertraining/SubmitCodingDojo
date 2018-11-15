using System;
using System.Linq;

namespace HomeWork1
{
    public class Program : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            string[] str = text.Split(','); 
            Array.Sort<string>(str); 
            return string.Join(',', str);
        }

    }
}
