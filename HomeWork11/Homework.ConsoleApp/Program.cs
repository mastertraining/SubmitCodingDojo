using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Homework.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var homework11 = new Homework11();
            Console.Write("Please input number: ");
            var number = int.Parse(Console.ReadLine());
            var wordOfNumber = homework11.GetReadWordOfNumber(number);
            Console.WriteLine(wordOfNumber);
        }
    }
}