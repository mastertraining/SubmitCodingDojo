using Homework6.Lib;
using System;

namespace Homework6.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new Homework06();
            Console.WriteLine(svc.LoadState());

            while (true)
            {
                Console.Write("Please choose LED to turn On/Off: ");

                var ledNo = Console.ReadLine();

                var isCorrectNumber = int.TryParse(ledNo, out var ledNoText) && ledNoText >= 1 && ledNoText <= 9;
                var isA = ledNo == "A";
                var isSave = ledNo == "save";

                if (isCorrectNumber || isA)
                {
                    Console.WriteLine(svc.DisplayLEDOnScreen(ledNo));
                }
                else if (isSave)
                {
                    svc.SaveCurrentState();
                    Console.WriteLine("Current state had been saved!");
                    Console.WriteLine(svc.LoadState());
                }
                else
                {
                    Console.WriteLine("Type 1-9 or A to turn on/off switch and Type 'save' to save state");
                }
            }
        }
    }
}
