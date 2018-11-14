using System;
using System.Linq;
using System.Text;

namespace multipliedclasslib
{
    public class multiplied : ITextMultiplier
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string GetFormattedString(string text)
        {
            //split
            var Split = text.Split(',');
            //convert && *
            var convert = Split.Select(x => (int.Parse(x)*11).ToString());
            //Join ","
            var addcomma = string.Join(",\n\t",convert);
            // add []
            var add = new StringBuilder();
            add.Append($"[\n\t{addcomma}\n]");

            return add.ToString();
        }

    
    }
}
