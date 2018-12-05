using System;
using System.Collections.Generic;
using System.Linq;

namespace homework13.lib
{
    public class FinderNinetyNineSet : IHomework13
    {
        public int Homework13(IEnumerable<int> numbers)
        {
            var numberStrings = numbers.Select(it => it.ToString());
            return numberStrings.Where(it => FinderNinetyNine(it)).Count();
        }

        private bool FinderNinetyNine(string text)
        {
            var isTextValid = text.Contains("99");
            if (!isTextValid) return false;

            for (int i = 0; i < text.Length - 1; i++)
            {
                var isNinetyNineNumber = text[i] == '9' && text[i + 1] == '9';
                if (!isNinetyNineNumber) continue;

                var nextNumberIndex = i + 2;
                var previousNumberIndex = i - 1;
                var isNextNumberBeNine = nextNumberIndex < text.Length ? text[nextNumberIndex] == '9' : false;
                var isPreviousNumberBeNine = previousNumberIndex >= 0 ? text[previousNumberIndex] == '9' : false;
                if (!isNextNumberBeNine && !isPreviousNumberBeNine) return true;
            }
            return false;
        }
    }
}
