using System;

namespace SortingAlphabetclasslib
{
    public class SortingAlphabets : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
           //split
            var split = text.Split(',');

            //sort
            Array.Sort(split);

            //Join ","
            var addcomma = string.Join(",",split);

            return addcomma;
        }
    }
}
