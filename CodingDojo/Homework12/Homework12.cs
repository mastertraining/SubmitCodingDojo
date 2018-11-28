using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework12
{
    public class Homework12 : IHomework12
    {
        public char FirstDuplicateCharactor(string text)
        {
            var firstDuplicate = text.GroupBy(it => it).FirstOrDefault(it => it.Count() > 1);
            return firstDuplicate == null ? '-' : firstDuplicate.Key;
        }

        public char FirstNotDuplicateCharactor(string text)
        {
            var firstNotDuplicate = text.GroupBy(it => it).FirstOrDefault(it => it.Count() == 1);
            return firstNotDuplicate == null ? '-' : firstNotDuplicate.Key;
        }
    }
}
