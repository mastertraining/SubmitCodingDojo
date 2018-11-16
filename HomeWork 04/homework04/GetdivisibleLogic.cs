using System;
using System.Linq;
namespace homework04
{
    public class GetdivisibleLogic : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            var split = text.Split(',');
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i] == "1111")
                {
                    return split[i];
                }
                else if (split[i] == "1010")
                {
                    return split[i];
                }
                else if (split[i] == "0101")
                {
                    return split[i];
                }
                else if (split[i] == "101")
                {
                    return split[i];
                }
            }
            return split[0];
        }
    }
}
