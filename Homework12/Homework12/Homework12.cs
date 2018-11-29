using System.Linq;

namespace Homework12
{
    public class Homework12 : IHomework12
    {
        public char FirstDuplicateCharactor(string text)
        {
            var firstDuplicateChar = text.ToCharArray().GroupBy(it => it).FirstOrDefault(it => it.Count() > 1);
            var result = firstDuplicateChar == null ? '-' : firstDuplicateChar.Key;
            return result;
        }

        public char FirstNotDuplicateCharactor(string text)
        {
            var firstNotDuplicateChar = text.ToCharArray().GroupBy(it => it).FirstOrDefault(it => it.Count() < 2d);
            var result = firstNotDuplicateChar == null ? '-' : firstNotDuplicateChar.Key;
            return result;
        }
    }
}
