using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework.ConsoleApp
{
    public class Homework08 : IHomework08
    {
        public string GetTriangleShapeAsText(int input)
        {
            var triangle = new StringBuilder();
            for (int i = 1; i <= input; i++)
            {
                var frontSpace = new string(' ', input - i);
                var backSpace = (i == input) ? new string('_', i - 1) : new string(' ', i - 1);
                triangle.Append(frontSpace).Append("/").Append(backSpace).Append("|");
                if (i != input)
                {
                    triangle.AppendLine();
                }
            }
            return triangle.ToString();
        }
    }
}