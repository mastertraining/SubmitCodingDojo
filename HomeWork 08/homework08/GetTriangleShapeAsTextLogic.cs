using System;
using System.Text;
namespace homework08
{
    public class GetTriangleShapeAsTextLogic : IHomework08
    {
        public string GetTriangleShapeAsText(int input)
        {
            var sb = new StringBuilder();
            for (int i = 1; i <= input; i++)
            {
                var frontSpace = new string(' ', input - i);
                var backSpace = (i == input) ? new string('_', i - 1) : new string(' ', i - 1);
                sb.AppendLine().Append(frontSpace).Append("/").Append(backSpace).Append("|");
            }
            return sb.ToString();
        }
    }
}
