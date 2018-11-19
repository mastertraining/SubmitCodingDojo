using System;
using System.Collections.Generic;
using Homework_classlib;

namespace Homework_console
{
    class Program
    {
        static void Main(string[] args)
        {
            var LED = new Homework05();
            LED.listLED = new List<string>(new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" });
            LED.listNoLED = new List<string>(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" });
            var ledNo = "start";

            do
            {
                var displayLED = LED.DisplayLEDOnScreen(ledNo);
                Console.WriteLine(displayLED);
                Console.Write("Please choose LED to turn On/Off: ");
                ledNo = Console.ReadLine();
            } while (!(string.IsNullOrWhiteSpace(ledNo)));
        }
    }
}
