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
            string displyaLED = "Start";
            var loadState = hw6.LoadState();
            if (loadState != "NoFile")
            {
                Console.WriteLine(loadState);
            }
            while (true)
            {
                if (loadState == "NoFile")
                {
                    displyaLED = hw6.DisplayLEDOnScreen(noLed);
                    Console.WriteLine(displyaLED);
                    Console.Write("Please choose LED to turn On/Off: ");
                    noLed = Console.ReadLine();
                    if (noLed == "Save")
                    {
                        hw6.SaveCurrentState();
                    }
                }
                else
                {
                    Console.Write("Please choose LED to turn On/Off: ");
                    noLed = Console.ReadLine();
                    displyaLED = hw6.DisplayLEDOnScreen(noLed);
                    Console.WriteLine(displyaLED);
                    if (noLed == "Save")
                    {
                        hw6.SaveCurrentState();
                    }
                }
            }
        }
    }
}
