using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork4.classlib
{
    public class HomeWork4Classlib : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            var splitString = text.Split(',').ToList();
            var listNumber = splitString.Where(elements => Convert.ToInt32(elements,2) % 5 == 0).ToList();
            string result;
            if(listNumber.Count() != 0) {
                result = String.Join(",",listNumber);
            }
            else {
                result = "";
            }
            return result;
        }
    }
}
