using System;
using System.Linq;

namespace HomeWork12.classlib
{
    public class HomeWork12ClassLib : IHomework12
    {
        public char FirstDuplicateCharactor(string text)
        {
            var firstTextDuplicate = text.GroupBy(element => element).FirstOrDefault(element => element.Count() > 1);
            var result = firstTextDuplicate.Any() ? firstTextDuplicate.Key : '-';
            return result;
        }

        public char FirstNotDuplicateCharactor(string text)
        {
            var firstTextNotDuplicate = text.GroupBy(element => element).FirstOrDefault(it => it.Count() == 1);
            var result = firstTextNotDuplicate.Any() ? firstTextNotDuplicate.Key : '-';
            return result;
        }
    }
}