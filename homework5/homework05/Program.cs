using System;
using System.Linq;
using System.Text;

namespace homework05
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var ledNo = new logicDisplayLEDOnScreen();
            var result = ledNo.DisplayLEDOnScreen(input);
            System.Console.WriteLine(result);


           

            
        }
    }
}


