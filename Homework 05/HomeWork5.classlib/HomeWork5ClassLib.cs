using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HomeWork5.classlib
{
    public class HomeWork5ClassLib : IHomework05
    {
        public Dictionary<string,string> listLed { get; set; }
        public string DisplayLEDOnScreen(string ledNo)
        {   
            var ledNoUpper = ledNo.ToUpper();
            if (listLed.ContainsKey(ledNoUpper)) {
                if(listLed[ledNoUpper] == "[ ]") {
                    listLed[ledNoUpper] = "[!]";
                }
                else {
                    listLed[ledNoUpper] = "[ ]";
                }
            }
            var keyLed = listLed.Keys;
            var valuesLed = listLed.Values;
            var listKeyLed = String.Join("   ",keyLed);
            var listValueLed = String.Join(" ",valuesLed);

            var sb = new StringBuilder();
            var resultDisplayLed = sb.AppendLine(listValueLed).Append(" ").Append(listKeyLed).ToString();

            return resultDisplayLed;
        }
    }
}
