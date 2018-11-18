using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var LED = new Homework05();
            LED.SetLED();
            var ledNo = "start";
            do
            {
                var displayLED = LED.DisplayLEDOnScreen(ledNo);
                Console.WriteLine(displayLED);
                Console.Write("Please choose LED to turn On/Off: ");
                ledNo = Console.ReadLine();
            } while (!(string.IsNullOrWhiteSpace(ledNo)));
            Console.WriteLine("###### Thank You ######");
        }
    }
}