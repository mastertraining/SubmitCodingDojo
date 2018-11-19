using System;
using Homework05.classlib;
using System.Collections.Generic;

namespace Homework05.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var led = new LED();
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
