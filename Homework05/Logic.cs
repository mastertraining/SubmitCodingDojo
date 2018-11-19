using System;
using System.Text;

namespace Homework05
{
    class Logic : IHomework05
    {
        public string DisplayLEDOnScreen(string ledNo)
        {
            var switchh = new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
            var switchhledNo = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };

            for (int j = 0; j < switchhledNo.Length; j++)
            {
                if (ledNo == switchhledNo[j])
                {
                    if (switchh[j] == "[ ]")
                    {
                        switchh[j] = "[!]";
                    }
                    else
                    {
                        switchh[j] = "[ ]";
                    }
                }
            }

            var resultswitchh = string.Join(" ", switchh);
            var resultswitchhledNo = string.Join("   ", switchhledNo);
            var result = new StringBuilder();
            result.Append(resultswitchh).Append(resultswitchhledNo);

            return result.ToString();
            
        }
    }
}
