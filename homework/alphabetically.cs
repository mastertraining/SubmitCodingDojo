using System;

namespace homework
{
    public class alphabetically : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            string word = text;
            var result = word.Split(',');
            Array.Sort(result);
            string alphabetically = string.Join(",", result);
            
            
            return alphabetically;
        }
    }
}
