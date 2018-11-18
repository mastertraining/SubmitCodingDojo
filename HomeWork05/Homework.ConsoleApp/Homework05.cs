using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework.ConsoleApp
{
    public class Homework05 : IHomework05
    {
        public Dictionary<string, string> LED { get; set; }

        public void SetLED()
        {
            LED = new Dictionary<string, string>()
            {
                {"1", "[ ]"},
                {"2", "[ ]"},
                {"3", "[ ]"},
                {"4", "[ ]"},
                {"5", "[ ]"},
                {"6", "[ ]"},
                {"7", "[ ]"},
                {"8", "[ ]"},
                {"9", "[ ]"},
                {"A", "[ ]"}
            };
        }

        public string DisplayLEDOnScreen(string ledNo)
        {
            ledNo = ledNo.ToUpper();

            if (LED.ContainsKey(ledNo))
            {
                LED[ledNo] = (LED[ledNo] == "[ ]") ? "[!]" : "[ ]";
            }

            var ledValue = string.Join(" ", LED.Values);
            var ledKeys = string.Join("   ", LED.Keys);

            var displayLED = new StringBuilder();
            displayLED.Append(ledValue).AppendLine().Append(" ").Append(ledKeys);

            return displayLED.ToString();
        }
    }
}