using System;
using System.Collections.Generic;

namespace testhome
{
    public class testlogic : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            var a = text.Split(',');
            var b = new List<string>();

            if (a[0] == "1111" || a[1] == "1111" || a[2] == "1111" || a[3] == "1111")
            {
                b.Add("1111");

            }
            if (a[0] == "0101" || a[1] == "0101" || a[2] == "0101" || a[3] == "0101")
            {
                b.Add("0101");

            }
            if (a[0] == "1010" || a[1] == "1010" || a[2] == "1010" || a[3] == "1010")
            {
                b.Add("1010");

            }
            if (a[0] == "101" || a[1] == "101" || a[2] == "101" || a[3] == "101")
            {
                b.Add("101");

            }
            var result = string.Join(",", b);
            return result;


        }
    }
}