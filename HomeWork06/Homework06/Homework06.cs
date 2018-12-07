using System;
using System.IO;
using YamlDotNet.RepresentationModel;

namespace Homework06
{
    public class Homework06 : IHomework06
    {
        private const string configPath = @"config.yaml";
        private const string statePath = @"savestate.txt";
        private string[] ledArray;
        private string[] switchNo;
        private bool[] ledSwitch;
        private string offSymbol;
        private string onSymbol;
        private int spaceNo;

        private void ReadYaml()
        {
            var input = new StreamReader(configPath);
            var yaml = new YamlStream();
            yaml.Load(input);
            var mapping = (YamlMappingNode)yaml.Documents[0].RootNode;
            onSymbol = mapping.Children.TryGetValue("on-symbol", out var outOnSymbol) && !string.IsNullOrEmpty(outOnSymbol.ToString()) ? outOnSymbol.ToString() : "!";
            offSymbol = mapping.Children.TryGetValue("off-symbol", out var outOffSymbol) && !string.IsNullOrEmpty(outOffSymbol.ToString()) ? outOffSymbol.ToString() : " ";
            var spaceParse = mapping.Children.TryGetValue("spaces", out var yamSpace) ? yamSpace.ToString() : "1";
            spaceNo = int.TryParse(spaceParse, out var spaceCount) ? spaceCount : 1;
        }

        private void SetSwitch(string input)
        {
            switch (input)
            {
                case "1":
                    if (ledSwitch[0])
                    {
                        ledSwitch[0] = false;
                        ledArray[0] = $"[{offSymbol}]";
                    }
                    else
                    {
                        ledSwitch[0] = true;
                        ledArray[0] = $"[{onSymbol}]";
                    }
                    break;
                case "2":
                    if (ledSwitch[1])
                    {
                        ledSwitch[1] = false;
                        ledArray[1] = $"[{offSymbol}]";
                    }
                    else
                    {
                        ledSwitch[1] = true;
                        ledArray[1] = $"[{onSymbol}]";
                    }
                    break;
                case "3":
                    if (ledSwitch[2])
                    {
                        ledSwitch[2] = false;
                        ledArray[2] = $"[{offSymbol}]";
                    }
                    else
                    {
                        ledSwitch[2] = true;
                        ledArray[2] = $"[{onSymbol}]";
                    }
                    break;
                case "4":
                    if (ledSwitch[3])
                    {
                        ledSwitch[3] = false;
                        ledArray[3] = $"[{offSymbol}]";
                    }
                    else
                    {
                        ledSwitch[3] = true;
                        ledArray[3] = $"[{onSymbol}]";
                    }
                    break;
                case "5":
                    if (ledSwitch[4])
                    {
                        ledSwitch[4] = false;
                        ledArray[4] = $"[{offSymbol}]";
                    }
                    else
                    {
                        ledSwitch[4] = true;
                        ledArray[4] = $"[{onSymbol}]";
                    }
                    break;
                case "6":
                    if (ledSwitch[5])
                    {
                        ledSwitch[5] = false;
                        ledArray[5] = $"[{offSymbol}]";
                    }
                    else
                    {
                        ledSwitch[5] = true;
                        ledArray[5] = $"[{onSymbol}]";
                    }
                    break;
                case "7":
                    if (ledSwitch[6])
                    {
                        ledSwitch[6] = false;
                        ledArray[6] = $"[{offSymbol}]";
                    }
                    else
                    {
                        ledSwitch[6] = true;
                        ledArray[6] = $"[{onSymbol}]";
                    }
                    break;
                case "8":
                    if (ledSwitch[7])
                    {
                        ledSwitch[7] = false;
                        ledArray[7] = $"[{offSymbol}]";
                    }
                    else
                    {
                        ledSwitch[7] = true;
                        ledArray[7] = $"[{onSymbol}]";
                    }
                    break;
                case "9":
                    if (ledSwitch[8])
                    {
                        ledSwitch[8] = false;
                        ledArray[8] = $"[{offSymbol}]";
                    }
                    else
                    {
                        ledSwitch[8] = true;
                        ledArray[8] = $"[{onSymbol}]";
                    }
                    break;
                case "A":
                    if (ledSwitch[9])
                    {
                        ledSwitch[9] = false;
                        ledArray[9] = $"[{offSymbol}]";
                    }
                    else
                    {
                        ledSwitch[9] = true;
                        ledArray[9] = $"[{onSymbol}]";
                    }
                    break;
                case "save":
                    SaveCurrentState();
                    break;
                case "":
                    break;
                default:
                    Console.WriteLine("Wrong input !");
                    break;
            }
        }

        public Homework06()
        {
            ledArray = new string[10] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
            switchNo = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
            ledSwitch = new bool[10] { false, false, false, false, false, false, false, false, false, false };
            var displayinit = LoadState();
            Console.WriteLine(displayinit);
        }

        public string DisplayLEDOnScreen(string ledNo)
        {
            SetSwitch(ledNo);
            return $"{String.Join(new string(' ', spaceNo), ledArray)}{Environment.NewLine} {String.Join(new string(' ', spaceNo + 2), switchNo)}";
        }

        public string LoadState()
        {
            ReadYaml();

            if (!File.Exists(statePath))
            {
                using (StreamWriter sw = File.CreateText(statePath))
                {
                    sw.WriteLine(string.Join(",", ledSwitch));
                }
            }

            var textRead = System.IO.File.ReadAllText(statePath);
            var readArray = textRead.Split(',');
            for (int i = 0; i < readArray.Length; i++)
            {
                ledSwitch[i] = bool.Parse(readArray[i]);
            }

            SetAppConfigurations(onSymbol, offSymbol, spaceNo);

            return DisplayLEDOnScreen("");
        }

        public void SaveCurrentState()
        {
            if (!File.Exists(statePath))
            {
                using (StreamWriter sw = File.CreateText(statePath))
                {
                    sw.WriteLine(string.Join(",", ledSwitch));
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(statePath))
                {
                    sw.WriteLine(string.Join(",", ledSwitch));
                }
            }
            Console.WriteLine("Current state had been saved!");
        }

        public void SetAppConfigurations(string onSymbol, string offSymbol, int spacing)
        {
            this.offSymbol = offSymbol;
            this.onSymbol = onSymbol;
            this.spaceNo = spacing;

            for (int i = 0; i < ledArray.Length; i++)
            {
                var displaySymbol = ledSwitch[i] ? $"[{onSymbol}]" : $"[{offSymbol}]";
                ledArray[i] = ledArray[i].Replace("[ ]", displaySymbol);
            }
        }
    }
}
