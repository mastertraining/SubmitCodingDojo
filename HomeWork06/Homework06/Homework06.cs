using System;
using System.IO;
using YamlDotNet.RepresentationModel;

namespace Homework06
{
    public class Homework06 : IHomework06
    {
        private const string configPath = @"config.yaml";
        private string[] ledArray = new string[10] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
        private readonly string[] switchNo = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
        private bool[] ledSwitch = new bool[10] { false, false, false, false, false, false, false, false, false, false, };
        private string offSymbol;
        private string onSymbol;
        private int spaceNo = 0;

        public string DisplayLEDOnScreen(string ledNo)
        {
            var a = File.Exists(configPath);
            ReadYaml();
            SetAppConfigurations("*", " ", 2);
            SetSwitch(ledNo);
            return $"{String.Join(new string(' ', spaceNo), ledArray)}{Environment.NewLine} {String.Join(new string(' ', spaceNo + 2), switchNo)}";
        }

        public string LoadState()
        {
            //TODO
            throw new NotImplementedException();
        }

        public void SaveCurrentState()
        {
            //TODO
            throw new NotImplementedException();
        }

        public void ReadYaml()
        {
            var input = new StreamReader(configPath);
            // Load the stream
            var yaml = new YamlStream();
            yaml.Load(input);

            // Examine the stream
            var mapping = (YamlMappingNode)yaml.Documents[0].RootNode;
            foreach (var entry in mapping.Children)
            {
                Console.WriteLine(((YamlScalarNode)entry.Key).Value);
            }
        }

        public void SetAppConfigurations(string onSymbol, string offSymbol, int spacing)
        {
            this.offSymbol = offSymbol;
            this.onSymbol = onSymbol;
            this.spaceNo = spacing;
        }

        private void SetSwitch(string input)
        {
            switch (input.ToUpper())
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
                        ledArray[2] = $"[{offSymbol}]";
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
                    //TODO : implement Save state
                    break;
                case "":
                    break;
                default:
                    Console.WriteLine("Wrong input !");
                    break;
            }
        }

    }
}
