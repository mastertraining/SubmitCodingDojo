using System;
using System.Text;
using HomeworkclassLib;

namespace Homework14
{
    class Program
    {
        static void Main(string[] args)
        {
            var sn = new Logic();
            sn.SetupANewGame();
            Console.WriteLine(sn.StartGame);

            while (true)
            {
                Console.Write("Please input a number: ");
                var input = int.Parse(Console.ReadLine());
                var result = sn.GetGameResult(input);
                Console.WriteLine(result);
            }
            Console.WriteLine("Good BYE");

        }
    }
}
