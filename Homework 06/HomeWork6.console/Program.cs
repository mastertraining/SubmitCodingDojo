using System;
using HomeWork6.classlib;
using System.Linq;

namespace HomeWork6.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw6 = new HomeWork6ClassLib();
            bool statusSave = false;
            var saveMessage = "Current state had been saved!";
            hw6.defaultLED();
            var noLed = "Close";
            string displyaLED = "Start";
            var loadState = hw6.LoadState();
            hw6.statusLED = loadState.Split(' ').ToList();
            // if (loadState != "NoFile")
            // {
            //     Console.WriteLine(loadState);
            // }
            while (true)
            {
                if (loadState == "NoFile")
                {
                    if (statusSave)
                    {
                        Console.WriteLine(saveMessage);
                    }
                    displyaLED = hw6.DisplayLEDOnScreen(noLed);
                    Console.WriteLine(displyaLED);
                    Console.Write("Please choose LED to turn On/Off: ");
                    noLed = Console.ReadLine();
                    statusSave = false;
                    if (noLed == "Save")
                    {
                        hw6.SaveCurrentState();
                        statusSave = true;
                    }
                }
                else
                {
                    displyaLED = hw6.DisplayLEDOnScreen(noLed);
                    Console.WriteLine(displyaLED);
                    Console.Write("Please choose LED to turn On/Off: ");
                    noLed = Console.ReadLine();
                    statusSave = false;
                    if (noLed == "Save")
                    {
                        hw6.SaveCurrentState();
                        statusSave = true;
                    }
                    if (statusSave)
                    {
                        Console.WriteLine(saveMessage);
                    }
                }
            }
        }
    }
}
