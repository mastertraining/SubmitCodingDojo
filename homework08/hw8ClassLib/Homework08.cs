using System;
using System.Text;

namespace hw8ClassLib
{
    public class Homework08 : IHomework08
    {
        public string GetTriangleShapeAsText(int input)
        {
            var build = new StringBuilder();

            for (int i = 1; i <= input; i++)
            {
                var outSpace = input - i;
                var intSpace = i - 1;
                for (int j = 1; j <= outSpace; j++)
                {
                    build.Append(' ');
                }
                build.Append('/');
                for (int k = 1; k <= intSpace; k++)
                {
                    var symbolIn = (i == input) ? '_' : ' ';
                    build.Append(symbolIn);
                }
                build.AppendLine("|");
            }
           
            return build.ToString();
        }
    }
}
