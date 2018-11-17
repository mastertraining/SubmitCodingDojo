using System;
using System.Text;

namespace hw5ClassLib
{
    public class Homework05 : IHomework05
    {
        public string DisplayLEDOnScreen(string ledNo)
        {
            var LEDs = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
            var LED = new StringBuilder();
            var num = new StringBuilder();
            // Thread.Sleep(500);
            var text = Console.Read();


            for (int i = 0; i < LEDs.Length; i++)
            {
                LED.Append('[').Append('!').Append("]");
                // Console.Write($"[ ]{Environment.NewLine}{i} ");
            }
            for (int i = 0; i < LEDs.Length; i++)
            {
                num.Append(' ').Append(LEDs[i]).Append(' ');
                // Console.Write($"[ ]{Environment.NewLine}{i} ");
            }
            return ledNo;
        }
    }
}
