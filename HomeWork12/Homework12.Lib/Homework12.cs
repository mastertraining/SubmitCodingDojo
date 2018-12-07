using Homework12.Lib.Contract;
using System;
using System.Linq;

namespace Homework12.Lib
{
    public class Homework12 : IHomework12
    {
        public char FirstDuplicateCharactor(string text)
        {
            var firstDuplicateChar = text.ToCharArray().GroupBy(it => it).FirstOrDefault(it => it.Count() > 1)?.Key;
            var result = firstDuplicateChar.Equals(null) ? '-' : firstDuplicateChar;
            return result.Value;
        }

        public char FirstNotDuplicateCharactor(string text)
        {
            var firstNotDuplicateChar = text.ToCharArray().GroupBy(it => it).FirstOrDefault(it => it.Count() == 1)?.Key;
            var result = firstNotDuplicateChar.Equals(null) ? '-' : firstNotDuplicateChar;
            return result.Value;
        }
    }
}
