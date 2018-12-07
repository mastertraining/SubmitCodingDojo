using System;
using System.Linq;

namespace hw12
{
    public class logic : IHomework12
    {
        public char FirstDuplicateCharactor(string text)
        {
            var word = text.GroupBy(it => it).FirstOrDefault(it => it.Count() > 1);
            var result = word == null ? '-' : word.Key;
            return result;
        }

        public char FirstNotDuplicateCharactor(string text)
        {
            var word = text.GroupBy(it => it).FirstOrDefault(it => it.Count() == 1);
            var result = word == null ? '-' : word.Key;
            return result;
        }
    }
}