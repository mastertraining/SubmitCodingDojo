using System;
using System.Collections.Generic;

    public class homework01 : ITextSorting
    {
        public string SortByAlphabetical (string text)
        {
            List<string> words = new List<string>(text.Split(','));
            words.Sort();

            return string.Join(",", words);
        }
    }
