using System;

namespace HomeWork05.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new Homework05();
            Console.WriteLine(svc.DisplayLEDOnScreen(""));
            while (true)
            {
                Console.Write("Please choose LED to turn On/Off: ");
                var led = svc.DisplayLEDOnScreen(Console.ReadLine());
                Console.WriteLine(led);
            }
        }
    }
}
