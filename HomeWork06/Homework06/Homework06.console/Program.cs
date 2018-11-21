using System;
using System.IO;

namespace Homework06.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new Homework06();
            var displayLoaded = svc.LoadState();
            Console.WriteLine(displayLoaded);
            while (true)
            {
                Console.Write("Please choose LED to turn On/Off: ");
                var led = svc.DisplayLEDOnScreen(Console.ReadLine());
                Console.WriteLine(led);
            }
        }
    }
}
