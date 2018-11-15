using System;
using System.Linq;

namespace HomeWork1
{
    public class Program : ITextSorting
    {
        string ITextSorting.SortByAlphabetical(string text)
        {
            string[] str = text.Split(','); 
            Array.Sort<string>(str); 
            return string.Join(',', str);
        }

    }
}
