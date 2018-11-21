using System;
using System.Linq;

namespace Homework_classlib 
{
    public class Homework07 : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var newTextSplit = text.Split(' ');
            Array.Sort(newTextSplit);
            var distinct = newTextSplit.Distinct();
            return  string.Join(" ", distinct);  
        }
    }
}
