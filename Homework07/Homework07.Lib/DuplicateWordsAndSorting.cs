using System;
using System.Linq;
namespace Homework07.Lib {
    public class DuplicateWordsAndSorting : IHomework07 {
        public string RemoveAndSortTextByAlphabetical(string text) 
        {
            var subString = text.Split(' ').ToList().Distinct().OrderBy(x => x).ToList();
            var newString = String.Join(" ", subString);
            return newString;
        }
    }
}