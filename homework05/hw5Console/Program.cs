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
            var hw5 = new Homework05();
            hw5.listLED = new List<string>(new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" });
            hw5.listNoLED = new List<string>(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" });
            var noLed = "close";
            while (true)
            {
                var disPlayLED = hw5.DisplayLEDOnScreen(noLed);
                Console.WriteLine(disPlayLED);
                Console.Write("Please choose LED to turn On/Off: ");
                noLed = Console.ReadLine();
                if (string.IsNullOrEmpty(noLed))
                {
                    break;
                }
            }
        }
    }
}

