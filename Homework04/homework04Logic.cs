using System;

namespace homework04
{
    public class homework04Logic : IHomework04
    {
        public string GetDivisibleBy5Text(string text)
        {
            string[] intput = text.Split(',');
            string[] result = new string[intput.Length];
            for (int i = 0; i < intput.Length; i++)
            {
                if (Convert.ToInt32(intput[i], 2) % 5 == 0)
                {
                    result[i] = intput[i];
                }
            }
            return string.Join(",", result);
        }
    }
}