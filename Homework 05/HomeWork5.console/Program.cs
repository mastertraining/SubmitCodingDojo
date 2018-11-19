using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HomeWork5.classlib;

namespace HomeWork5.console
{
    class Program
    {
        static void Main(string[] args)
        {   
            var hw5 = new HomeWork5ClassLib();
            hw5.listLed = new Dictionary<string, string>();
            hw5.listLed.Add("1","[ ]");
            hw5.listLed.Add("2","[ ]");
            hw5.listLed.Add("3","[ ]");
            hw5.listLed.Add("4","[ ]");
            hw5.listLed.Add("5","[ ]");
            hw5.listLed.Add("6","[ ]");
            hw5.listLed.Add("7","[ ]");
            hw5.listLed.Add("8","[ ]");
            hw5.listLed.Add("9","[ ]");
            hw5.listLed.Add("A","[ ]");
            var ledNo = "close";
            while (true) {

                var displayLed =hw5.DisplayLEDOnScreen(ledNo);
                Console.WriteLine(displayLed);
                Console.Write("Please choose LED to turn On/Off:  ");
                ledNo = Console.ReadLine();
            }
        }
    }
}
