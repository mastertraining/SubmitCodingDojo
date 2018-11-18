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
            LED = new Dictionary<string, string>();
            LED.Add("1", "[ ]");
            LED.Add("2", "[ ]");
            LED.Add("3", "[ ]");
            LED.Add("4", "[ ]");
            LED.Add("5", "[ ]");
            LED.Add("6", "[ ]");
            LED.Add("7", "[ ]");
            LED.Add("8", "[ ]");
            LED.Add("9", "[ ]");
            LED.Add("A", "[ ]");
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