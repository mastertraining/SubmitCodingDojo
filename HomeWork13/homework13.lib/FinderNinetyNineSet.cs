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

            for (int i = 0; i < text.Length; i++)
            {
                var isNinetyNineNumber = text[i] == '9';
                if (!isNinetyNineNumber) continue;

                var isNextNumberBeNine = false;
                if (i + 1 < text.Length) isNextNumberBeNine = text[i + 1] == '9';

                var isBeyoundNextNumberBeNine = false;
                if (i + 2 < text.Length) isBeyoundNextNumberBeNine = text[i + 2] == '9';

                var isPreviousNumberBeNine = false;
                if (i - 1 >= 0) isPreviousNumberBeNine = text[i - 1] == '9';

                if (isNextNumberBeNine && !isBeyoundNextNumberBeNine && !isPreviousNumberBeNine) return true;
            }
            return false;
        }
    }
}
