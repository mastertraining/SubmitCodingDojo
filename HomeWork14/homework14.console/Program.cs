using System;
using homework14.lib;

namespace homework14.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello Welcome to Sports runner game analysis (HomeWork 14)");

            var gameControl = new Homework14();
            var isRunningGame = true;
            while (isRunningGame)
            {
                Console.WriteLine(gameControl.RenderDistance);

                var displayMessage = gameControl.IsGameEnd ? "Do you want to try again?: " : "Please input a number: ";
                Console.Write(displayMessage);
                var input = Console.ReadLine();
                switch (input)
                {
                    case "yes": gameControl.SetupANewGame(); break;
                    case "no": isRunningGame = false; break;
                    default:
                        int.TryParse(input, out int number);
                        gameControl.GetGameResult(number);
                        break;
                }
            }
        }
    }
}
