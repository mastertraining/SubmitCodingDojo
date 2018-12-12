using System;
using Homework8.classlib;

namespace Homework08.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var peramid = new Peramid();

            int countPeramid;
            System.Console.Write("Input : ");
            countPeramid = int.Parse(Console.ReadLine());
            var result = peramid.GetTriangleShapeAsText(countPeramid);

            System.Console.Write(result);


        }
    }
}
