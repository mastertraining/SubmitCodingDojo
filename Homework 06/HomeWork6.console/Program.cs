using System;
using HomeWork6.classlib;

namespace HomeWork6.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw6 = new HomeWork6ClassLib();
            hw6.defaultLED();
            var noLed = "Close";
            var loadState = hw6.LoadState();
            Console.WriteLine(loadState);

            while (true)
            {
                Console.Write("Please choose LED to turn On/Off: ");
                noLed = Console.ReadLine();
                var displyaLED = hw6.DisplayLEDOnScreen(noLed);
                Console.WriteLine(displyaLED);
                if (noLed == "Save")
                {
                    hw6.SaveCurrentState();
                }
            }
        }
    }
}
