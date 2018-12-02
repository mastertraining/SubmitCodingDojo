using System;
using System.Collections.Generic;

namespace Homework.Lib
{
    public class Binary : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            var input = text.Split(',');
            var mod = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                var octal = Convert.ToInt32(input[i], 2);
                if (octal % 5 == 0)
                {
                    mod.Add(input[i]);
                }
            }

            var result = string.Join(",", mod);

            return result;
        }
    }
}
