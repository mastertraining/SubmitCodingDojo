using System;

namespace Homework09
{
    class ProgramHomework09
    {
        static void Main(string[] args)
        { 
            var a = new Homework09Logic();
            Console.WriteLine("Products in your cart are");
            Console.WriteLine("None"); 
            Console.WriteLine("- - - - - - - - - -");
            Console.WriteLine("Total amount:"+"Bath");
            Console.WriteLine("Please input a product key:");
            var input = Console.ReadLine();
            var getproduct = new Homework09Logic();
            getproduct.AddProductToCart(a);
        
        }
    }
}
