using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_08
{
    public class Homework08 : IHomework08
    {
        public string GetTriangleShapeAsText(int input)
        {
            var strBuilder = new StringBuilder();
            for (int i = 1; i <= input; i++)
            {
                var baseSign = i == input ? '_' : ' ';
                strBuilder.Append(new string(' ', input - i))
                    .Append('/').Append(new string(baseSign, i - 1))
                    .AppendLine("|");
            }
            return strBuilder.ToString();
        }
    }
}
