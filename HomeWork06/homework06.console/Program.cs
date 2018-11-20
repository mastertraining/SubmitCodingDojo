using System;
using System.Collections.Generic;
using homework06.lib;

namespace homework06.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var displayMessage = new List<string>();
            var announceText = $"Hello Welcome to DisplayLEDOnScreen analysis (HomeWork 05)";
            var rulesText = $"Rules:{Environment.NewLine}\tInput: 1 - 9 and 'A' or 'a' only{Environment.NewLine}\tInput: 0 for exit program";
            var ledScreen = $"Led Screen:{Environment.NewLine}\t[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]{Environment.NewLine}\t 1   2   3   4   5   6   7   8   9   A";

            displayMessage.Add(announceText);
            displayMessage.Add(rulesText);
            displayMessage.Add(ledScreen);
            var message = string.Join(Environment.NewLine, displayMessage);
            System.Console.Write(message);

            var ledOnScreen = new Homework06();
            var isContinueInputLedOnScreen = true;
            while (isContinueInputLedOnScreen)
            {
                System.Console.Write($"{Environment.NewLine}Please choose LED to turn On/Off: ");
                var input = Console.ReadLine();
                if (input.Equals("0")) isContinueInputLedOnScreen = false;
                else
                {
                    var displayLed = ledOnScreen.DisplayLEDOnScreen(input);
                    System.Console.WriteLine(displayLed);
                }
            }
            System.Console.WriteLine("Exit program!");
        }
    }
}
