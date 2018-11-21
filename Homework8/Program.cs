using System;
using System.Text;

namespace Homework8
{
    class Program: IHomework08
    {
        static void Main(string[] args)
        {
            Program prm = new Program();
            Console.WriteLine(prm.GetTriangleShapeAsText(15));
        }

        public string GetTriangleShapeAsText(int input)
        {
            StringBuilder triangle = new StringBuilder();
            string hypotenuse = "/";
            string adjacent   = "|";
            char   opposite   = '_';
            char   blank      = ' ';

            for (int i = 0; i < input; i++) 
            {
                if (i == input - 1)
                {
                    triangle.Append(new string(blank, input - i))
                            .Append(hypotenuse)
                            .Append(new string(opposite, i))
                            .AppendLine(adjacent);
                }
                else 
                {
                    triangle.Append(new string(blank, input - i))
                            .Append(hypotenuse)
                            .Append(new string(blank, i))
                            .AppendLine(adjacent);
                }
            }

            return triangle.ToString();
        }
    }
}
