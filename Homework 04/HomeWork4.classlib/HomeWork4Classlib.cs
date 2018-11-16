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
            if(listNumber.Count() != 0) {
                text = String.Join(",",listNumber);
            }
            else {
                text = "";
            }
            return text;
        }
    }
}
