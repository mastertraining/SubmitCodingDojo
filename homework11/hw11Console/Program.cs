using System;
using hw11ClassLib;

namespace hw11Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw11 = new Homework11();

            while (true)
            {
                Console.Write("Please input number: ");
                var input = Console.ReadLine();
                
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                var result = hw11.GetReadWordOfNumber(int.Parse(input));
                Console.WriteLine(result);
            }
        }
    }
}
