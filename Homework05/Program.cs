using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework05
{
    class Program
    {
        static void Main(string[] args)
        {          
            string switchhB = "[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]";
            string switchNo = " 1   2   3   4   5   6   7   8   9   A";
            var add = new StringBuilder();
            var display = add.Append($"{switchhB}\n{switchNo}");
            System.Console.WriteLine(display);
            System.Console.WriteLine("Please choose LED to turn On/Off:");

            while (true)
            {
                var input = System.Console.ReadLine();
                var test = new Logic();
                var result = test.DisplayLEDOnScreen(input);

                System.Console.Write(result);
            }

            // }
            // bool isturnoff = true;
            // string input = "1";

            // string a = "[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]";
            // string number = " 1   2   3   4   5   6   7   8   9   A";
            // var add = new StringBuilder();
            // var aadd = add.Append($"{a}\n{number}");

            // string c = "[!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]";
            // var cadd = new StringBuilder();
            // var caddd = cadd.Append($"{c}\n{number}");

            // while (input == "1")
            // {
            //     if (isturnoff)
            //     {
            //         System.Console.WriteLine(aadd);
            //         System.Console.WriteLine("Please choose LED to turn On: ");
            //     }
            //     else
            //     {
            //         System.Console.WriteLine(caddd);
            //         System.Console.WriteLine("Please choose LED to turn On/Off: ");
            //     }
            //     isturnoff = !isturnoff;
            //     input = System.Console.ReadLine();

            // }
            // Console.WriteLine("Exit program");
        }
    }
}
