using System;
using System.Collections.Generic;
using Homework03.classlib;

namespace Homework03.console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = new List<string>();

            System.Console.WriteLine("Input String for Upper :");
            int String_Line = int.Parse(Console.ReadLine());

            for (int i = 0; i < String_Line; i++)
            {
                text.Add(Console.ReadLine());
            }
            var Text_Upper = new StringToUpper();
            var result = Text_Upper.GetFormattedString(text);
            
            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }   
           
            

            
            // var String_sum = new StringSort();
            // string result = String_sum.ToUpper();
            // Console.WriteLine("Hello World!");
        }
    }
}
