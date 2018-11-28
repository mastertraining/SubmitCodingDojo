using System;
using homework08;

namespace homework08Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Please input a number : ");
            var number = int.Parse(Console.ReadLine());
            var sut = new GetTriangleShapeAsTextLogic();
            var result = sut.GetTriangleShapeAsText(number);
            System.Console.WriteLine(result);
        }
    }
}
