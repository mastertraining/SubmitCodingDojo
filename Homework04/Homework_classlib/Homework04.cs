using System;
using System.Linq;
using System.Collections.Generic;

namespace Homework_classlib
{
    public class Homework04 : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            var arrayText = text.Split(',');
            var newText = new List<string>();
            foreach (var item in arrayText)
            {
                if (Convert.ToInt32(item, 2) % 5 == 0)
                {
                    newText.Add(item);
                }
            }
            return string.Join(",",newText);
        }
    }
}
