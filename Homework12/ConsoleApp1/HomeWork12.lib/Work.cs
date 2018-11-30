using System;
using System.Linq;

namespace HomeWork12.lib
{
    public class Work : IHomework12
    {
        public char FirstDuplicateCharactor(string text)
        {
            var data = text.GroupBy(it => it).FirstOrDefault(it => it.Count() > 1);
            var result = data != null ? data.First() : '-';
            return result;
        }

        public char FirstNotDuplicateCharactor(string text)
        {
            var data = text.GroupBy(it => it).FirstOrDefault(it => it.Count() == 1);
            var result = data != null ? data.First() : '-';
            return result;

        }
    }
}
