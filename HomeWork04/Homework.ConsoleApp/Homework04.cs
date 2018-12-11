using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework.ConsoleApp
{
    public class Homework04 : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            var arrayText = text.Split(',').Where(it => Convert.ToInt32(it, 2) % 5 == 0).ToArray();
            return string.Join(',', arrayText);
        }
    }
}