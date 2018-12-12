using System;
using System.Collections.Generic;
using System.Text;
using Homework04.classlib;
using System.Linq;

namespace Homework04.console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input From DivisibleBy5Text 0100,0011,1010,1001,0101
            System.Console.Write("Input Binary2 To Find Max Value : ");
            string Binary2 = (Console.ReadLine());

            var String_Binary2 = new DivisibleBy5Text();
            System.Console.WriteLine(String_Binary2.GetDivisibleBy5Text(Binary2));
        }
    }
}
