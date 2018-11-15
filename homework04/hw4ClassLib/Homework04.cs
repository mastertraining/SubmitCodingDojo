using System;
using System.Linq;
using System.Text;

namespace hw4ClassLib
{
    public class Homework04 : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            var sprit = text.Split(',');
            var divBy5 = sprit.Where(it => Convert.ToInt32(it, 2) % 5 == 0).ToArray();
            var returnText = string.Join(",", divBy5);
            return returnText;
        }
    }
}
