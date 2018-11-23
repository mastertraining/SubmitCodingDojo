using System;
using Homework_classlib;

namespace Homework_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number : ");
            var input = int.Parse(Console.ReadLine());
            var call = new Homework08();
            var newText = call.GetTriangleShapeAsText(input);
            Console.WriteLine(newText);
        }
    }
}
