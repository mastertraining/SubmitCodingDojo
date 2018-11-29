using System;
using System.Linq;

namespace homework12
{
    public class FirstDuplicateCharactorLogic : IHomework12
    {
        public char FirstDuplicateCharactor(string text)
        {
            var firstDuplicateChar = text.ToCharArray().GroupBy(it => it).FirstOrDefault(it => it.Count() > 1);
            var result = firstDuplicateChar == null ? '-' : firstDuplicateChar.Key;
            return result;
        }

        public char FirstNotDuplicateCharactor(string text)
        {
            var FirstNotDuplicateChar = text.ToCharArray().GroupBy(it => it).FirstOrDefault(it => it.Count() == 1);
            var result = FirstNotDuplicateChar == null ? '-' : FirstNotDuplicateChar.Key;
            return result;
        }
    }
}
