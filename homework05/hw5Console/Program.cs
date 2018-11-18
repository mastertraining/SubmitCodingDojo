using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using hw5ClassLib;

namespace hw5Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var LEDs = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
            var LED = new StringBuilder();
            var text = new List<string>() { " " };

            for (int i = 0; i < LEDs.Length; i++)
            {
                LED.Append("[ ]");
            }

            LED.Append(Environment.NewLine);

            for (int i = 0; i < LEDs.Length; i++)
            {
                LED.Append(' ').Append(LEDs[i]).Append(' ');
            }

            Console.WriteLine(LED);
            while (true)
            {
                Console.Write($"Please choose LED to turn On/Off: ");
                var input = Console.ReadLine().ToString();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                var showLED = new Homework05();
                var result = showLED.DisplayLEDOnScreen(input);
                Console.WriteLine(result);
                // text.Add(result);
                // foreach (var item in text)
                // {
                //     Console.WriteLine(item);
                // }


            }
        }
    }
}
