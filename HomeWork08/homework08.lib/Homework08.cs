using System;
using System.Text;

namespace homework08.lib
{
    public class Homework08 : IHomework08
    {
        public string GetTriangleShapeAsText(int input)
        {
            const int MinimumInput = 1;
            var isInputValid = input >= MinimumInput;
            if (!isInputValid) return string.Empty;

            var result = new StringBuilder();
            for (int i = 1; i <= input; i++)
            {
                var diagonalShape = "/".PadLeft((input - i) + 1);
                var isBaseTriangle = i == input;
                var baseLineTriangle = $"{new string('_', input - 1)}|";
                var perpendicularShape = isBaseTriangle ? baseLineTriangle : "|".PadLeft(i);
                var shape = $"{diagonalShape}{perpendicularShape}";
                result.AppendLine(shape);
            }
            return result.ToString();
        }
    }
}
