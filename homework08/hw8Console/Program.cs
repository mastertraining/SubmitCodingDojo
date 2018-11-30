using System;
using hw8ClassLib;

namespace hw8Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input data: ");
            var call = new Homework08();
            var input = Console.ReadLine();
            var result = call.GetTriangleShapeAsText(int.Parse(input));
            Console.Write(result);
        }
    }
}
