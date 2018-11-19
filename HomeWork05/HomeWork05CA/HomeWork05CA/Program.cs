using Homework05.lib;
using System;
using System.Collections.Generic;

namespace HomeWork05CA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var xxx = new HW05();
            xxx.setLED();
            var input = "";
            while (true)
            {
                var disPlayLED = xxx.DisplayLEDOnScreen(input);
                Console.WriteLine(disPlayLED);
                Console.Write("Please choose LED to turn On/Off: ");
                input = Console.ReadLine();
                if (input == "stop" || input == string.Empty)
                {
                    break;
                }
            }
        }
    }
}
