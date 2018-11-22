using System;

namespace Homework08.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new Homework08();
            while (true)
            {
                Console.WriteLine("Enter number : ");
                var result = int.TryParse(Console.ReadLine(), out var number) ? svc.GetTriangleShapeAsText(number) : "Please enter number.";
                Console.WriteLine(result);
            }
        }
    }
}
