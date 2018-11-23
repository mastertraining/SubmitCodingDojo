using System;
using System.Text;

namespace homework8
{
    public class logic : IHomework08
    {
        public string GetTriangleShapeAsText(int input)
        {
            var Builder = new StringBuilder();
            int count = input;
            for (int i = 1; i <= count; i++)
            {
                var triangle = i == count ? '_' : ' ';
                Builder.Append(new string(' ', count - i))
                .Append('/').Append(new string(triangle, i - 1))
                .AppendLine("|");
            }
            return  Builder.ToString();
        }
    }
}