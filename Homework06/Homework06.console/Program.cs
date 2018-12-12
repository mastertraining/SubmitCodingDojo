using System;
using Homework06.classlib;

namespace Homework06.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var led = new LEDV2();
            led.defaultLight();
            var numberSlot = "";
            while (true)
            {
                var listLED = led.DisplayLEDOnScreen(numberSlot);
                System.Console.WriteLine(listLED);

                System.Console.Write("Please choose LED to turn On/Off: ");
                numberSlot = Console.ReadLine();
            }
        }
    }
}
