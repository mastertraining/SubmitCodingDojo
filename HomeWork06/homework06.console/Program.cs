using System;
using System.Collections.Generic;
using System.Text;
using homework06.lib;

namespace homework06.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var ledOnScreenControl = new Homework06();
            var announceText = $"Hello Welcome to DisplayLEDOnScreen analysis (HomeWork 06)";
            var announceRules = $"Rules:{Environment.NewLine}\tInput: 1 - 9 and 'A' or 'a' only{Environment.NewLine}\tInput: 'exit' for exit program{Environment.NewLine}\tInput: 'save' for save state (if unsaved, It will disppear when close the program{Environment.NewLine}\tInput: 'load' for load state file{Environment.NewLine}\tInput: 'rule' for display rules again";
            var ledScreen = $"Current Led Screen:{Environment.NewLine}{ledOnScreenControl.LoadState()}";

            var displayAnnounces = new StringBuilder().AppendLine(announceText).AppendLine(announceRules).AppendLine(ledScreen);
            System.Console.Write(displayAnnounces);

            var isContinueInputLedOnScreen = true;
            while (isContinueInputLedOnScreen)
            {
                System.Console.Write($"{Environment.NewLine}Please choose LED to turn On/Off: ");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "exit": isContinueInputLedOnScreen = false; break;
                    case "save": ledOnScreenControl.SaveCurrentState(); break;
                    case "rule":
                        var ruleText = $"{new String('=', 60)}{Environment.NewLine}{announceRules}{Environment.NewLine}{ledScreen}";
                        System.Console.WriteLine(ruleText);
                        break;
                    case "load":
                        ledScreen = $"Current Led Screen:{Environment.NewLine}{ledOnScreenControl.LoadState()}";
                        System.Console.WriteLine(ledScreen);
                        break;
                    default:
                        var currentLedScreen = ledOnScreenControl.DisplayLEDOnScreen(input);
                        System.Console.WriteLine(currentLedScreen);
                        break;
                }
            }
            System.Console.WriteLine("Exit program!");
        }
    }
}
