using System;
using System.Text;

namespace HomeWork8.classlib
{
    public class HomeWork8ClassLib : IHomework08
    {
        public string GetTriangleShapeAsText(int input)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < input; i++)
            {
                if (i == 0)
                {
                    sb.Append(new string(' ', input - (i + 1))).Append("/").AppendLine("|");
                }
                else if (i == input - 1)
                {
                    sb.Append("/").Append(new string('_', i)).AppendLine("|");
                }
                else
                {
                    sb.Append(new string(' ', input - (i + 1))).Append("/").Append(new string(' ', i)).AppendLine("|");
                }
            }

            return sb.ToString();
        }
    }
}
