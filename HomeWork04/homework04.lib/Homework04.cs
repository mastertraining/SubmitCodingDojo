using System;
using System.Linq;
using System.Text;

namespace homework04.lib
{
    public class Homework04 : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            Func<string, string> DivisibleByFive = (it) =>
                {
                    var convert = Convert.ToInt32(it, 2);
                    if (convert % 5 == 0) return it;
                    return string.Empty;
                };

            var isTextValid = !string.IsNullOrWhiteSpace(text);
            if (!isTextValid) return string.Empty;

            var textSplited = text.Split(',');
            var isOnlyFourDigit = !textSplited.Any(it => it.Length != 4);
            if (!isOnlyFourDigit) return string.Empty;

            var TwoBinary = textSplited.Select(DivisibleByFive).Where(it => !string.IsNullOrWhiteSpace(it));
            return string.Join(",", TwoBinary);
        }
    }
}
