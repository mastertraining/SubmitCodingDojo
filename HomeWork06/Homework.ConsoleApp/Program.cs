using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Homework.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var LED = new Homework06();
            Console.WriteLine(LED.LoadState());
            Console.Write("Please choose LED to turn On/Off: ");
            string ledNo;
            do
            {
                ledNo = Console.ReadLine();
                if (ledNo == "save")
                {
                    LED.SaveCurrentState();
                    break;
                }
                var displayLED = LED.DisplayLEDOnScreen(ledNo);
                Console.WriteLine(displayLED);
                Console.Write("Please choose LED to turn On/Off: ");
            } while (!(string.IsNullOrWhiteSpace(ledNo)));
        }
    }
}