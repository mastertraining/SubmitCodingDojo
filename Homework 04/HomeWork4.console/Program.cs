using System;
using HomeWork4.classlib;

namespace HomeWork4.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw4ClassLib = new HomeWork4Classlib();
            Console.Write("Enter 2 digit Number : ");
            var twoDigitNumber = Console.ReadLine();
            var result = hw4ClassLib.GetDivisibleBy5Text(twoDigitNumber);
            if (result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("No 2 Digits Number that Devided by 5");
            }
        }
    }
}
