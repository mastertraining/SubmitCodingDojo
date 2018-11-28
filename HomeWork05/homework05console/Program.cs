using System;
using System.Text;
using homework05;

namespace homework05console
{
    class Program
    {
        static void Main(string[] args)
        {

            var leds = "[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]";
            var number = " 1   2   3   4   5   6   7   8   9   A";
            var add = new StringBuilder();
            var showDisplay = add.Append($"{leds}\n{number}");
            System.Console.WriteLine(showDisplay);
            Console.WriteLine("Please choose LED to turn On/Off: ");
            var ledNo = Console.ReadLine();


            while (true)
            {
                var ledcall = new DisplayLEDLogic();
                var result = ledcall.DisplayLEDOnScreen(ledNo);
                Console.WriteLine(result);
                Console.WriteLine("Please choose LED to turn On/Off: ");
                ledNo = Console.ReadLine();
            }


        }
    }
}
