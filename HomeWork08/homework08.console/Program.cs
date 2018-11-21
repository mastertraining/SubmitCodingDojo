using System;
using homework08.lib;

namespace homework08.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Hello Welcome to GetTriangleShapeAsText analysis (HomeWork 08){Environment.NewLine}How many do you want to build TriangleShape height?: ");
            int.TryParse(Console.ReadLine(), out int input);

            var isValidInput = input > 0;
            if (!isValidInput)
            {
                System.Console.WriteLine("Your input must more than or equal 1.");
                return;
            }

            var control = new Homework08();
            var result = control.GetTriangleShapeAsText(input);
            System.Console.WriteLine($"Result{Environment.NewLine}{result}");

        }
    }
}
