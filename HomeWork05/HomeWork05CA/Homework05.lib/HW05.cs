using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Homework05.lib
{
    public class HW05 : IHomework05
    {
        public List<string> listLED { get; set; }
        public List<string> listNumberLED { get; set; }

        public void setLED()
        {
            listLED = new List<string>(new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" });
            listNumberLED = new List<string>(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" });
        }

        public string DisplayLEDOnScreen(string input)
        {
            input = input.ToUpper();
            var sb = new StringBuilder();
            for (int i = 0; i < listNumberLED.Count; i++)
            {
                if (input == listNumberLED[i])
                {
                    if (listLED[i] == "[ ]")
                    {
                        listLED[i] = "[!]";
                    }
                    else
                    {
                        listLED[i] = "[ ]";
                    }
                }
            }
            var resultLED = String.Join(" ", listLED);
            var resultNoLED = String.Join("   ", listNumberLED);
            sb.AppendLine(resultLED).Append(" ").Append(resultNoLED);
            return sb.ToString();
        }
    }
}
