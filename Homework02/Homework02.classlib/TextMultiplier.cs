using System;

namespace Homework02.classlib
{
    public class TextMultiplier : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {

            var textsplit = text.Split(',');
            for (int i = 0; i < textsplit.Length; i++)
            {
                var convert = int.Parse(textsplit[i]);
                textsplit[i] = (convert * 11).ToString();
            }

            var join = string.Join(",\n\t", textsplit);
            var result = string.Format("[\n\t{0}\n]", join);
            return result;
        }
    }
}
