using System;
using System.Linq;

namespace homework12.lib
{
    public class Homework12 : IHomework12
    {
        public char FirstDuplicateCharactor(string text)
        {
            const char DefaultResult = '-';
            var isTextValid = !string.IsNullOrWhiteSpace(text);
            if (!isTextValid) return DefaultResult;

            var charArray = text.ToCharArray().ToList();
            for (int i = 0; i < charArray.Count; i++)
            {
                var copyCharArray = text.ToCharArray().ToList();
                copyCharArray.RemoveAt(i);

                var isDuplicated = copyCharArray.Any(it => it.Equals(charArray[i]));
                if (isDuplicated) return charArray[i];
            }
            return DefaultResult;
        }

        public char FirstNotDuplicateCharactor(string text)
        {
            const char DefaultResult = '-';
            var isTextValid = !string.IsNullOrWhiteSpace(text);
            if (!isTextValid) return DefaultResult;

            var charArray = text.ToCharArray().ToList();
            for (int i = 0; i < charArray.Count; i++)
            {
                var copyCharArray = text.ToCharArray().ToList();
                copyCharArray.RemoveAt(i);

                var isUnique = !copyCharArray.Any(it => it.Equals(charArray[i]));
                if (isUnique) return charArray[i];
            }
            return DefaultResult;
        }
    }
}
