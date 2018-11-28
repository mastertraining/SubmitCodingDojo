using System;
using System.Linq;

namespace HomeWork12.classlib
{
    public class HomeWork12ClassLib : IHomework12
    {
        public char FirstDuplicateCharactor(string text)
        {
            var firstDuplicate = text.GroupBy(element => element).FirstOrDefault(element => element.Count() > 1);
            var result = firstDuplicate.Any() ? firstDuplicate.Key : '-';
            return result;
        }

        public char FirstNotDuplicateCharactor(string text)
        {
            var firstNotDuplicate = text.GroupBy(element => element).FirstOrDefault(it => it.Count() == 1);
            var result = firstNotDuplicate.Any() ? firstNotDuplicate.Key : '-';
            return result;
        }
    }
}
