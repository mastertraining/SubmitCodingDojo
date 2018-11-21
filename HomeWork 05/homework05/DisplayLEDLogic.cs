using System;
using System.Linq;
using System.Text;

namespace homework05
{
    public class DisplayLEDLogic : IHomework05
    {
        public string[] listLED { get; set; }
        public string[] ledNumber { get; set; }
        public string DisplayLEDOnScreen(string ledNo)
        {
            listLED = new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
            ledNumber = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", };
            var led = ledNo.ToUpper();
            var sb = new StringBuilder();
            for (int i = 0; i < ledNumber.Length; i++)
            {
                if (led == ledNumber[i])
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
            var result = string.Join("   ", ledNumber);
            var resultLED = String.Join(" ", listLED);
            sb.AppendLine(resultLED).Append(" ").AppendLine(result);
            return sb.ToString();
        }
    }
}
