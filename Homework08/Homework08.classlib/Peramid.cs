using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8.classlib
{
    public class Peramid : IHomework08
    {
        public string GetTriangleShapeAsText(int input)
        {

            var countPeramid = new StringBuilder();

            for (int i = 0; i < input; i++)
            {

                if (i == 0 && i == input - 1)
                {
                    countPeramid.Append(new string(' ', input - (i + 1))).Append("/").AppendLine("|");
                    countPeramid.Append("/").Append(new string('_', i)).AppendLine("|");
                }
                else if (i == input - 1)
                {
                    countPeramid.Append("/").Append(new string('_', i)).AppendLine("|");
                }
                else
                {
                    countPeramid.Append(new string(' ', input - (i + 1))).Append("/").Append(new string(' ', i)).AppendLine("|");
                }

            }
            return countPeramid.ToString();
        }


    }
}
