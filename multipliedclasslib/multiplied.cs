using System;

namespace multipliedclasslib
{
    class multiplied : ITextMultiplier
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string GetFormattedString(string text)
        {
            //split
            var Split = text.Split(',');
            // int[] a = int.Parse(Split);

            return "Split";
        }

    
    }
}
