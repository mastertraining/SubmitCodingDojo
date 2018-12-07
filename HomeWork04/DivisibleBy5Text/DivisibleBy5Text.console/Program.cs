using System;
using System.Collections.Generic;

namespace DivisibleBy5Text.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputSet = new List<string>();
            var svc = new DivisibleBy5Text.Homework04();
            Console.WriteLine("Please enter 4 number :");
            while (true)
            {
                var words = Console.ReadLine().ToString();
                if (words == string.Empty)
                {
                    break;
                }
                else if (int.TryParse(words, out int output) && words.Length == 4)
                {
                    inputSet.Add(words);
                }
                else
                {
                    Console.WriteLine("Your number is wrong. Please enter again ..");
                }
            }
            var numberFourDigit = string.Join(",", inputSet);
            var numberDivideByFive = svc.GetDivisibleBy5Text(numberFourDigit);
            Console.WriteLine("Your input is : {0}", numberFourDigit);
            Console.WriteLine("Result : {0}", numberDivideByFive);
            Console.Read();
        }
    }
}
