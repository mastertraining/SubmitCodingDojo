using System;
using HomeWork8.classlib;

namespace HomeWork8.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw8 = new HomeWork8ClassLib();
            while (true)
            {
                Console.Write("Enter number: ");
                var number = int.Parse(Console.ReadLine());
                var result = hw8.GetTriangleShapeAsText(number);
                Console.Write(result);
            }
        }
    }
}
