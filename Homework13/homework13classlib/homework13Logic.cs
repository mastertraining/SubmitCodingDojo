using System;
using System.Collections.Generic;

namespace homework13classlib
{
    public class homework13Logic : IHomework13
    {
        public int Homework13(IEnumerable<int> numbers)
        {
            var numberschar = numbers.ToString().ToCharArray();
            var count = 0;
            if (numberschar[0] == 9 && numberschar[1] == 9)
            {
                // count ++;
                return 1;
            }
            return 0;



            // var count = 0;
            // foreach (var numb in numbers)
            // {
            //     var StrNum = numb.ToString();
            //     for (int i = 0; i < StrNum.Length; i++)
            //     {
            //         if (StrNum[i] == '9')
            //         {
            //             count++;
            //         }
            //     }

            // }
            // return count;


            
        }
    }
}
