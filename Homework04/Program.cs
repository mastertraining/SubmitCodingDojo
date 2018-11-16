using System;

namespace homework04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            var text = Console.ReadLine();

            var sut = new homework04Logic();
            var result = sut.GetDivisibleBy5Text(text);
           
             Console.WriteLine(result);
                
            
        }
    }
}
