using System;
using System.Text;
using Homework02.classlib;

namespace Homework02.console
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("");
            string numbers = Console.ReadLine();
            
            var numbers_sum = new StringSort();
            var result = numbers_sum.GetFormattedString(numbers);

            System.Console.WriteLine(result);
        }
    }
}
