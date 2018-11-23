using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_classlib
{
    public class Homework08 : IHomework08
    {
        public string GetTriangleShapeAsText(int input)
        {
            var build = new StringBuilder();

            for (int i = 1; i <= input; i++)
            {
                var space = input - i;
                var underLine = i - 1;
                var symbol = ' ';
                for (int j = 1; j <= space; j++)
                {
                    build.Append(' ');
                }
                build.Append('/');
                for (int k = 1; k <= underLine; k++)
                {
                    if (i == input)
                    {
                        symbol = '_';
                    }
                    else
                    {
                        symbol = ' ';
                    }
                    build.Append(symbol);
                }
                build.AppendLine("|");
            }

            return build.ToString();
        }
    }
}
