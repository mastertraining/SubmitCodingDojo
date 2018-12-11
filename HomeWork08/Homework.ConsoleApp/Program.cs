using System;
using System.Collections.Generic;

namespace Homework.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number : ");
            var number = int.Parse(Console.ReadLine());
            var sut = new Homework08();
            var newText = sut.GetTriangleShapeAsText(number);
            Console.WriteLine(newText);
        }
    }
}