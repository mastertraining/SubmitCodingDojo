using System;
using System.Text;

namespace homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1      /|
            // 2     / |
            // 3    /  |
            // 4   /   |
            // 5  /____|
            // Console.WriteLine("  /|\n"+" / |\n"+"/  | ");
            
            var input = int.Parse(Console.ReadLine());
            var number = new logic();
            var result = number.GetTriangleShapeAsText(input);
            System.Console.WriteLine(result);
            
           

        }
    }
}
