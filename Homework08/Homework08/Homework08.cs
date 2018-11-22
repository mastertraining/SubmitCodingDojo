using System;
using System.Text;

namespace Homework08
{
    public class Homework08 : IHomework08
    {
        public string GetTriangleShapeAsText(int input)
        {
            var startSymbol = "/";
            var baseSymbol = '_';
            var endSymbol = "|";
            var builder = new StringBuilder();
            var spaceStartCount = input;

            if (input > 1)
            {
                for (int i = 0; i < input; i++)
                {
                    var spaceSymbol = i == input - 1 ? baseSymbol : ' ';
                    spaceStartCount--;
                    builder.Append(spaceSymbol, spaceStartCount).Append(startSymbol).Append(spaceSymbol, i).Append(endSymbol);
                    if (i < input - 1) builder.Append(Environment.NewLine);
                }
                return builder.ToString();
            }
            return "Please enter a number that is greater than 1.";
        }
    }
}
