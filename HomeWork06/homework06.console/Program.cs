using System;
using System.Collections.Generic;
using homework06.lib;

namespace homework06.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var ledOnScreenControl = new Homework06();
            var displayMessage = new List<string>();
            var announceText = $"Hello Welcome to DisplayLEDOnScreen analysis (HomeWork 05)";
            var rulesText = $"Rules:{Environment.NewLine}\tInput: 1 - 9 and 'A' or 'a' only{Environment.NewLine}\tInput: 'exit' for exit program{Environment.NewLine}\tInput: 'save' for save state (if unsaved, It will disppear when close the program{Environment.NewLine}\tInput: 'rules' for display rules again";
            var ledScreen = $"Current Led Screen:{Environment.NewLine}{ledOnScreenControl.LoadState()}";

            displayMessage.Add(announceText);
            displayMessage.Add(rulesText);
            displayMessage.Add(ledScreen);
            var message = string.Join(Environment.NewLine, displayMessage);
            System.Console.Write(message);

            var isContinueInputLedOnScreen = true;
            while (isContinueInputLedOnScreen)
            {
                System.Console.Write($"{Environment.NewLine}Please choose LED to turn On/Off: ");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "exit": isContinueInputLedOnScreen = false; break;
                    case "save": ledOnScreenControl.SaveCurrentState(); break;
                    case "rules": System.Console.WriteLine($"{new String('=', 60)}{Environment.NewLine}{rulesText}{Environment.NewLine}{ledScreen}"); break;
                    default:
                        var displayLed = ledOnScreenControl.DisplayLEDOnScreen(input);
                        System.Console.WriteLine(displayLed);
                        break;
                }
            }
            System.Console.WriteLine("Exit program!");
        }
    }
}
