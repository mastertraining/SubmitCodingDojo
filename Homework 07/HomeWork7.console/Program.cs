using System;
using HomeWork7.classlib;

namespace HomeWork7.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw7 = new HomeWork7ClassLib();
            Console.Write("Enter String: ");
            var text = Console.ReadLine();
            var result = hw7.RemoveAndSortTextByAlphabetical(text);
            Console.WriteLine(result);
        }
    }
}
