using System;
using System.Linq;
using HomeWork04.lib;

namespace HomeWork04
{
    public class Homework04
    {
        public static void Main(string[] args)
        {
            string data = "1111,1010,0101,1001,1111,1010,0101,1001,1111,1010,0101,1001,1111,1010,0101,1001,101";
            var text = new HW04();
            var result = text.GetDivisibleBy5Text(data.ToString());
            Console.WriteLine(result);

        }
    }
}
