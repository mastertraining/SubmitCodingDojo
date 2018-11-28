using System;
using System.Linq;

namespace HomeWork7.classlib
{
    public class HomeWork7ClassLib : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {   
            var subString = text.Split(' ').ToList();
            var removeDuplicateString = subString.Distinct().ToList();
            var sortStringList = removeDuplicateString.OrderBy(element => element).ToList();
            var sortedString = String.Join(" ",sortStringList);
            
            return sortedString;
        }
    }
}
