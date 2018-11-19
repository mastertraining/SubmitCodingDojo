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
            bool isturnoff = true;
            string input = "1";

            string a = "[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]";
            string b = "[!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]";
            string number = " 1   2   3   4   5   6   7   8   9   A";
            var add = new StringBuilder();
            var aadd = add.Append($"{a}\n{number}");

            string c = "[!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]";
            var cadd = new StringBuilder();
            var caddd = cadd.Append($"{c}\n{number}");

            while (input == "1")
            {
                if (isturnoff)
                {
                    System.Console.WriteLine(aadd);
                    System.Console.WriteLine("Please choose LED to turn On: ");
                }
                else
                {
                    System.Console.WriteLine(caddd);
                    System.Console.WriteLine("Please choose LED to turn On/Off: ");
                }
                isturnoff = !isturnoff;
                input = System.Console.ReadLine();

            }
            Console.WriteLine("Exit program");





            //เครื่องโชว์สัตว์เลี้ยง
            //bool isshowcat = true;
            // string input = "y";
            // while (input == "y")
            // {
            //    if (isshowcat)
            //    {
            //        Console.WriteLine("Here a cute cat");
            //        Console.WriteLine("Do you want to see a dog (y/n)");
            //        //isshowcat = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Here an awesome dog");
            //        Console.WriteLine("Do you want to see a cat (y/n)");
            //        //isshowcat = true;
            //    }
            //    isshowcat = !isshowcat;
            //    input = Console.ReadLine();

            // }
            // Console.WriteLine("Good BYE");

        }
    }
}
