using System;
using HomeWork4.classlib;

namespace HomeWork4.console
{
    class Program
    {
        static void Main(string[] args)
        {   var hw4ClassLib = new HomeWork4Classlib();
            Console.Write("Enter 2 digit Number : ");
            string twoDigitNumber = Console.ReadLine();
            var result = hw4ClassLib.GetDivisibleBy5Text(twoDigitNumber);
            Console.WriteLine(result);
        }
    }
}
