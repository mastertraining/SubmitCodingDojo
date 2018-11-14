using System;

namespace homework2
{
    public class number : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            string input = (text);
            var number = input.Split(',');
            for(int i = 0;i< number.Length; i++)
            {
                var number2 = int.Parse(number[i]);
                number[i] =  (number2 * 11).ToString();
            }
                      
            var join = string.Join(",\n\t",number);
            var result = string.Format("[\n\t{0}\n]",join);
            return result;
        }

        
    }
}