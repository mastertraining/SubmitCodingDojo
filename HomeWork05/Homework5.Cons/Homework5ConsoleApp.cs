using System;
using Homework5.Lib;

namespace Homework5.Cons
{
    class Homework5ConsoleApp
    {
        static void Main(string[] args)
        {
            var svc = new Homework05();

            Console.WriteLine(@"[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]
 1   2   3   4   5   6   7   8   9   A");

            while (true)
            {
                Console.Write("Please choose LED to turn On/Off: ");

                var ledNo = Console.ReadLine();

                var isCorrectNumber = int.TryParse(ledNo, out var ledNoText) && ledNoText >= 1 && ledNoText <= 9;
                var isA = ledNo.ToUpper() == "A";

                if (isCorrectNumber || isA)
                {
                    Console.WriteLine(svc.DisplayLEDOnScreen(ledNo));
                }
                else
                {
                    Console.WriteLine("Please enter 1-9 or a/A ");
                }
            }
        }
    }
}
