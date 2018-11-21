using System;
using System.Text;

namespace ProgramHomework08
{
    class Program
    {
        static void Main(string[] args)
        {
             //1     /|
            //2    / |
            //3   /__|


            var left = "/";
            var right = "|";
            var center = "_";

            var add = new StringBuilder();
            //add.Append($"{left}{right}");


            Console.WriteLine("Please enter your triangle's height (start : number1)");
            var count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                if (count == 1)
                {
                    add.Append($"{left}{right}");
                    System.Console.WriteLine(add);
                }
                else if (count > 1)
                {
                    add.Append($"{left}_{right}");
                    //var addcomma = string.Join("++++", add);
                    System.Console.WriteLine(add);
                }
            }


            // while (count > 0)
            // {

            //     System.Console.WriteLine(add);


            //     count --;
            // }


            // var result = new Homework08Logic();
            // System.Console.WriteLine(result.GetTriangleShapeAsText(input));
        
        }
    }
}
