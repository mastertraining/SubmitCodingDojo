using System;
using System.Collections.Generic;

namespace Homework13
{
    public class Homework13 : IHomework13
    {
        int IHomework13.Homework13(IEnumerable<int> numbers)
        {
            int count = 0;
            foreach (var item in numbers)
            {
                var isNineNine = IsNineNineCheck(item);
                if (isNineNine)
                {
                    count++;
                }
            }
            return count;
        }

        public bool IsNineNineCheck (int number)
        {
            var specialNumber = '9';
            var numberText = number.ToString();
            for (int i = 0; i < numberText.Length; i++)
            {
                if(i == 4 && numberText[i] == specialNumber && numberText[i + 1] == specialNumber)
                {
                    return true;
                }
                else if(numberText[i] == specialNumber && numberText[i+1] == specialNumber)
                {
                    if(numberText[i+2] != specialNumber)
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }
    }
}
