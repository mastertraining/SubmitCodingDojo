using System.Linq;

namespace Homework12
{
    public class Homework12 : IHomework12
    {
        public char FirstDuplicateCharactor(string text)
        {
            var splitChar = text.ToCharArray().GroupBy(it => it).FirstOrDefault(it => it.Count() > 1);
            var result = splitChar == null ? '-' : splitChar.Key;
            return result;
        }

        public char FirstNotDuplicateCharactor(string text)
        {
            var splitChar = text.ToCharArray().GroupBy(it => it).FirstOrDefault(it => it.Count() < 2d);
            var result = splitChar == null ? '-' : splitChar.Key;
            return result;
        }
    }
}
