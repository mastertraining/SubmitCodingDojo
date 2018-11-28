using System;
using HomeWork11.classlib;

namespace HomeWork11.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw11 = new HomeWork11ClassLib();
            hw11.setDigit();
            while (true)
            {
                Console.Write("Please input number: ");
                var inputNumber = Convert.ToInt32(Console.ReadLine());
                var resultNumberToString = hw11.GetReadWordOfNumber(inputNumber);
                Console.WriteLine(resultNumberToString);
            }
        }
    }
}
