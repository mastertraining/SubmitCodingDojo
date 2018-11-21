using System;

namespace Homework06.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new Homework06();
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
