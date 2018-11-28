using System;
using System.Collections.Generic;
using System.Linq;

namespace homework12.lib
{
    public class Homework12 : IHomework12
    {
        public char FirstDuplicateCharactor(string text) => IsFindFirstUnique(text, false);

        public char FirstNotDuplicateCharactor(string text) => IsFindFirstUnique(text, true);

        private char IsFindFirstUnique(string text, bool isFindFirstUnique)
        {
            const char DefaultResult = '-';
            var isTextValid = !string.IsNullOrWhiteSpace(text);
            if (!isTextValid) return DefaultResult;

            var charArray = text.ToCharArray().ToList();
            foreach (var item in charArray)
            {
                var comparisonCharArry = new List<char>(charArray);
                comparisonCharArry.Remove(item);
                var isMatchedCondition = isFindFirstUnique ?
                                         !comparisonCharArry.Any(it => it.Equals(item)) : comparisonCharArry.Any(it => it.Equals(item));
                if (isMatchedCondition) return item;
            }
            return DefaultResult;
        }
    }
}
