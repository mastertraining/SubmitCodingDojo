using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using YamlDotNet.RepresentationModel;

namespace Homework_06
{
    public class Homework06 : IHomework06
    {
        private readonly int defaultspacing = 1;
        private readonly int defaultLedCount = 10;
        private readonly string defaultOnSymbol = "!";
        private readonly string defaultOffSymbol = " ";
        private readonly string configPath = @"config.yaml";
        private readonly string saveStatePath = @"saveLedOnIndex.txt";
        private readonly string configOffSpaces = "spaces";
        private readonly string configOnSymbolName = "on-symbol";
        private readonly string configOffSymbolName = "off-symbol";

        private IList<string> ledIndex;
        private IList<string> ledStatus;
        private string ledOnSign;
        private string ledOffSign;
        private string ledStatusWriteSpace;
        private string ledIndexWriteSpace;
        private IDictionary<int, string> ledIndexName = new Dictionary<int, string>();

        public Homework06()
        {
            RegisterIndexName();
            LoadState();
        }

        private void RegisterIndexName() => ledIndexName.Add(10, "A");

        public string DisplayLEDOnScreen(string ledNo)
        {
            var index = ledIndex.IndexOf(ledNo);
            if (index != -1)
                ledStatus[index] = ledStatus[index] == ledOffSign ? ledOnSign : ledOffSign;

            return LedStateWriteLine();
        }

        private string LedStateWriteLine()
        {
            var ledStatusWriteLine = string.Join(ledStatusWriteSpace, ledStatus);
            var ledIndexWriteLine = string.Join(ledIndexWriteSpace, ledIndex);
            return $"{ledStatusWriteLine}{Environment.NewLine} {ledIndexWriteLine}";
        }

        public string LoadState()
        {
            if (File.Exists(configPath))
                using (var reader = new StreamReader(configPath))
                {
                    var yaml = new YamlStream();
                    yaml.Load(reader);
                    var configData = (YamlMappingNode)yaml.Documents[0].RootNode;
                    SetSymbol(configData.Children);
                }
            else
            {
                using (var writer = File.CreateText(configPath))
                {
                    var newConfig = new YamlMappingNode();
                    newConfig.Children.Add(configOnSymbolName, defaultOnSymbol);
                    newConfig.Children.Add(configOffSymbolName, defaultOffSymbol);
                    newConfig.Children.Add(configOffSpaces, defaultspacing.ToString());
                    SetSymbol(newConfig.Children);

                    var yaml = new YamlStream(new YamlDocument(newConfig));
                    yaml.Save(writer, false);
                }
            }

            if (File.Exists(saveStatePath))
            {
                var stateData = File.ReadAllText(saveStatePath);
                var stateList = stateData.Split(" ").ToList();
                stateList.ForEach(it =>
                {
                    var index = ledIndex.IndexOf(it);
                    if (index != -1)
                        ledStatus[index] = ledOnSign;
                });
            }
            return LedStateWriteLine();
        }

        private void SetSymbol(IDictionary<YamlNode, YamlNode> config)
        {
            ledOnSign = config.TryGetValue(configOnSymbolName, out var onSymbol) ? $"[{onSymbol}]" : $"[{defaultOnSymbol}]";
            ledOffSign = config.TryGetValue(configOffSymbolName, out var offSymbol) ? $"[{offSymbol}]" : $"[{defaultOffSymbol}]";
            if (config.TryGetValue(configOffSpaces, out var space))
            {
                var spacing = int.Parse(space.ToString());
                ledStatusWriteSpace = new string(' ', spacing);
                ledIndexWriteSpace = new string(' ', spacing + 2);
            }
            else
            {
                ledStatusWriteSpace = new string(' ', defaultspacing);
                ledIndexWriteSpace = new string(' ', defaultspacing + 2);
            };

            ledStatus = Enumerable.Repeat(ledOffSign, defaultLedCount).ToList();
            ledIndex = Enumerable.Range(1, defaultLedCount)
                .Select(it => ledIndexName.TryGetValue(it, out var value) ? value : it.ToString())
                .ToList();
        }

        public void SaveCurrentState()
        {
            var LedOnList = new List<string>();
            for (int i = 0; i < defaultLedCount; i++)
            {
                if (ledStatus[i] == ledOnSign)
                    LedOnList.Add(ledIndex[i]);
            }
            var saveLedOnText = string.Join(" ", LedOnList);
            File.WriteAllText(saveStatePath, saveLedOnText);
        }

        public void SetAppConfigurations(string onSymbol, string offSymbol, int spacing)
        {
            using (var writer = File.CreateText(configPath))
            {
                var newConfig = new YamlMappingNode();
                newConfig.Children.Add(configOnSymbolName, onSymbol);
                newConfig.Children.Add(configOffSymbolName, offSymbol);
                newConfig.Children.Add(configOffSpaces, spacing.ToString());
                SetSymbol(newConfig.Children);

                var yaml = new YamlStream(new YamlDocument(newConfig));
                yaml.Save(writer, false);
            }
        }
        
    }
}
