using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HomeWork3.classlib;

namespace HomeWork3.console
{
    class Program
    {
        static void Main(string[] args)
        {   
            var hw3ClassLib = new HomeWork3ClassLib();
            var sb = new StringBuilder();
            var listString = new List<string>();
            Console.Write("Enter Count of Input : ");
            var countInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < countInput; i++)
            {   
                Console.Write("Word {0} :",i + 1);
                listString.Add(Console.ReadLine());
            }
            var listUpperCase = hw3ClassLib.CapitalizedText(listString);
            Console.WriteLine("Result UpperCase :");
            foreach(var listUpper in listUpperCase) {
                sb.AppendLine(listUpper);
            }
            Console.Write(sb.ToString());
        }
    }
}
