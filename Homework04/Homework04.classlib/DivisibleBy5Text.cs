using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework04.classlib
{
    public class DivisibleBy5Text : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
              //0100,0011,1010,1001,0101
            string[] words = text.Split(',');
            var String_Binary = new List<string>();
            foreach (string word in words)
            {
                if (Convert.ToInt32(word, 2) % 5 == 0)
                {
                    String_Binary.Add(word);
                }
            }
            return string.Join(",",String_Binary);
        }
    }
}
