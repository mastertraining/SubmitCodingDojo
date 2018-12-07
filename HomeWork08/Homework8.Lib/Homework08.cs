using Homework8.Lib.Contract;
using System;
using System.Text;

namespace Homework8.Lib
{
    public class Homework08 : IHomework08
    {
        public string GetTriangleShapeAsText(int input)
        {
            var strBuider = new StringBuilder();
            for (int i = input - 1, j = 0; i >= 0; i--, j++)
            {
                var betweenTriText = i == 0 ? '_' : ' ';

                strBuider.Append(' ', i)
                    .Append('/')
                    .Append(betweenTriText, j)
                    .Append('|');

                var isLastLine = i == 0;
                if (!isLastLine)
                {
                    strBuider.AppendLine();
                }
            }

            return strBuider.ToString();
        }
    }
}
