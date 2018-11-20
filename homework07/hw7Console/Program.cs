using System;
using hw7ClassLib;

namespace hw7Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input text: ");
            var input = Console.ReadLine();
            var call = new Homework07();
            var showText = call.RemoveAndSortTextByAlphabetical(input);
            Console.Write(showText);
        }
    }
}
