using System;
using System.Linq;

namespace Homework_classlib
{
    public class Homework12 : IHomework12
    {
        public char FirstDuplicateCharactor(string text)
        {
            var newText = text.GroupBy(it => it).FirstOrDefault(it => it.Count() > 1);
            var result = newText != null ? newText.First() : '-';
            return result;
        }
        
        public char FirstNotDuplicateCharactor(string text)
        {
            var newText = text.GroupBy(it => it).FirstOrDefault(it => it.Count() == 1);
            var result = newText != null ? newText.First() : '-';
            return result; 
        }
    }
}
