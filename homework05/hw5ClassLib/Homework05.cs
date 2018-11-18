using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace hw5ClassLib
{
    public class Homework05 : IHomework05
    {
        public string DisplayLEDOnScreen(string ledNo)
        {
            ledNo = ledNo.ToUpper();
            var LEDs = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
            var LED = new StringBuilder();

            for (int i = 0; i < LEDs.Length; i++)
            {
                if (ledNo == LEDs[i])
                {
                    LED.Append("[!]");
                }
                else
                {
                    LED.Append("[ ]");
                }
            }

            LED.Append(Environment.NewLine);

            for (int i = 0; i < LEDs.Length; i++)
            {
                LED.Append(' ').Append(LEDs[i]).Append(' ');
            }

            return LED.ToString();
        }
    }
}
