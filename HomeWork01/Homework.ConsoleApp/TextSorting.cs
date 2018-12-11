using System;
using System.Linq;
using System.Text;

namespace Homework.ConsoleApp
{
    public class TextSorting : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            var words = text.Split(',');
            Array.Sort(words);
            var newText = string.Join(',', words);
            return newText;
        }
    }
}