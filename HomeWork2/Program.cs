using System;
using System.Linq;
using System.Text;

namespace HomeWork2
{
    class Program : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            int[] IntMult = Array.ConvertAll(text.Split(','), int.Parse);
            StringBuilder building = new StringBuilder();

            building.Append("[\n");
            int i = 0;
            foreach (var val in IntMult) {
                if (i < IntMult.Length - 1)
                    building.Append("\t").Append(val * 11).Append(",").Append("\n");
                else 
                    building.Append("\t").Append(val * 11).Append("\n");
                i++;
            }
            building.Append("]\n");

            return building.ToString();
        }
    }
}
