using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace HomeWork2.classlib
{
    public class SortNumber : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            var sb = new StringBuilder();
            var subString = text.Split(',');
            var numberList = new List<string>();
            foreach (var number in subString)
            {
                int result;
                result = int.Parse(number) * 11;
                numberList.Add(result.ToString());
            }

            sb.AppendLine("[");

            for (int i = 0 ; i < numberList.Count ; i++) {
        
                if(i == numberList.Count-1) {
                    sb.Append("\t").AppendLine(numberList[i]).Append("]");
                }
                else {
                     sb.Append("\t").Append(numberList[i]).AppendLine(",");
                }
            }
            return sb.ToString();
        }
    }
}
