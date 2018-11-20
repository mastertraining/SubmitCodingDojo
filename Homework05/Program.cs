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


            var input = System.Console.ReadLine();

            var test = new Logic();
            var result = test.DisplayLEDOnScreen(input);

            System.Console.Write(result);



            var ledNo = System.Console.ReadLine();
            //var switchh = new bool[] { false, false, false, false, false, false, false, false, false, false };
            string[] switchhB = new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
            var switchNo = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
            ledNo = ledNo.ToUpper();
            for (int i = 0; i < switchNo.Length; i++)
            {
                if (ledNo == switchNo[i])
                {
                    switchhB[i] = !switchhB[i];

                    Console.WriteLine(a);
                }
            }










        }
    }
}
