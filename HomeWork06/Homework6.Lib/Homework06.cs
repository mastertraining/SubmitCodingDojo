using Homework6.Lib.Contract;
using System;
using System.IO;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

namespace Homework6.Lib
{
    public class Homework06 : IHomework06
    {
        private const string ledStringPlattern = @"[*0]_[*1]_[*2]_[*3]_[*4]_[*5]_[*6]_[*7]_[*8]_[*9]
 1 _ 2 _ 3 _ 4 _ 5 _ 6 _ 7 _ 8 _ 9 _ A";
        private const string CONFIG_PATH = "config.yaml";
        private const string STATE_PATH = "state.txt";
        private string onSymbol;
        private string offSymbol;
        private int spaces;

        public bool[] Switches { get; set; }

        public Homework06()
        {
            ResetState();
            LoadAppConfigurations();
        }

        private void ResetState()
        {
            Switches = new bool[] { false, false, false, false, false, false, false, false, false, false };
        }

        private string GetLEDStringFromSwitches()
        {
            var ledString = ledStringPlattern;

            var spacing = new string(' ', spaces);
            ledString = ledString.Replace("_", spacing);

            for (int i = 0; i < Switches.Length; i++)
            {
                var switchDisplay = Switches[i] ? onSymbol : offSymbol;
                ledString = ledString.Replace($"*{i.ToString()}", switchDisplay);
            }
            return ledString;
        }

        private void SaveYmalFile(string onSymbol, string offSymbol, int spacing)
        {
            var ymal = new YamlMappingNode();
            ymal.Children.Add("on-symbol", onSymbol);
            ymal.Children.Add("off-symbol", offSymbol);
            ymal.Children.Add("spaces", spacing.ToString());

            using (var writer = File.CreateText(CONFIG_PATH))
            {
                var stream = new YamlStream(new YamlDocument(ymal));
                stream.Save(writer, false);
            }
        }

        private void LoadAppConfigurations()
        {
            var ymalDoc = new YamlMappingNode();

            if (File.Exists(CONFIG_PATH))
            {
                try
                {
                    using (var reader = File.OpenText(CONFIG_PATH))
                    {
                        var stream = new YamlStream();
                        stream.Load(reader);
                        ymalDoc = (YamlMappingNode)stream.Documents[0].RootNode;
                    }
                }
                catch (Exception e)
                {
                    SaveYmalFile("!", " ", 1);
                }
            }
            else
            {
                SaveYmalFile("!", " ", 1);
            }

            GetConfigurationsFromYmalDoc(ymalDoc, out var onSymbol, out var offSymbol, out var spaces);
            SetAppConfigurations(onSymbol, offSymbol, spaces);
        }

        private void GetConfigurationsFromYmalDoc(YamlMappingNode ymalDoc, out string onSymbol, out string offSymbol, out int spaces)
        {
            onSymbol = ymalDoc.Children.TryGetValue("on-symbol", out var temponsymbol) &&
                !string.IsNullOrWhiteSpace(temponsymbol.ToString()) &&
                temponsymbol.ToString().Length == 1 ? temponsymbol.ToString() : "!";
            offSymbol = ymalDoc.Children.TryGetValue("off-symbol", out var tempoffsymbol) &&
                !string.IsNullOrWhiteSpace(tempoffsymbol.ToString()) &&
                tempoffsymbol.ToString().Length == 1 ? tempoffsymbol.ToString() : " ";
            var spacesTxt = ymalDoc.Children.TryGetValue("spaces", out var tempspaces) ? tempspaces.ToString() : "1";
            spaces = int.TryParse(spacesTxt, out spaces) ? spaces : 1;
        }

        public string DisplayLEDOnScreen(string ledNo)
        {
            var index = ledNo == "A" ? 9 : int.Parse(ledNo) - 1;
            Switches[index] = !Switches[index];
            return GetLEDStringFromSwitches();
        }

        public string LoadState()
        {
            if (File.Exists(STATE_PATH))
            {
                var switches = File.ReadAllLines(STATE_PATH);

                for (int i = 0; i < switches.Length; i++)
                {
                    var isCorrectSwitchText = bool.TryParse(switches[i], out var swirchState);

                    if (isCorrectSwitchText)
                    {
                        Switches[i] = swirchState;
                    }
                    else
                    {
                        ResetState();
                        SaveCurrentState();
                        break;
                    }
                }
            }
            else
            {
                SaveCurrentState();
            }

            return GetLEDStringFromSwitches();
        }

        public void SaveCurrentState()
        {
            using (var writer = new StreamWriter(STATE_PATH))
            {
                foreach (var item in Switches)
                {
                    writer.WriteLine(item.ToString().ToLower());
                }
            }
        }

        public void SetAppConfigurations(string onSymbol, string offSymbol, int spacing)
        {
            this.onSymbol = onSymbol;
            this.offSymbol = offSymbol;
            this.spaces = spacing;
        }
    }
}