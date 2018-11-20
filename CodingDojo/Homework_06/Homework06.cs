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
        private IList<bool> ledStatus;
        private string ledOnSign;
        private string ledOffSign;
        private string ledStatusWriteSpace;
        private string ledIndexWriteSpace;
        private IDictionary<int, string> ledIndexName = new Dictionary<int, string>();

        public Homework06() => SetupLedSystem();

        private void SetupLedSystem()
        {
            RegisterIndexName();

            ledStatus = Enumerable.Repeat(false, defaultLedCount).ToList();
            ledIndex = Enumerable.Range(1, defaultLedCount)
                .Select(it => ledIndexName.TryGetValue(it, out var value) ? value : it.ToString())
                .ToList();

            LoadState();
        }

        private void RegisterIndexName() => ledIndexName.Add(10, "A");

        public string DisplayLEDOnScreen(string ledNo)
        {
            var index = ledIndex.IndexOf(ledNo);
            if (index != -1)
                ledStatus[index] = !ledStatus[index];

            return LedStateWriteLine();
        }

        private string LedStateWriteLine()
        {
            var stateSignList = ledStatus.Select(it => it ? ledOnSign : ledOffSign);
            var ledStatusWriteLine = string.Join(ledStatusWriteSpace, stateSignList);
            var ledIndexWriteLine = string.Join(ledIndexWriteSpace, ledIndex);
            return $"{ledStatusWriteLine}{Environment.NewLine} {ledIndexWriteLine}";
        }

        public string LoadState()
        {
            if (File.Exists(saveStatePath))
            {
                var stateData = File.ReadAllText(saveStatePath);
                var stateList = stateData.Split(" ").ToList();
                stateList.ForEach(it =>
                {
                    var index = ledIndex.IndexOf(it);
                    if (index != -1)
                        ledStatus[index] = true;
                });
            }

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
                SetAppConfigurations(defaultOnSymbol, defaultOffSymbol, defaultspacing);
            }
            return LedStateWriteLine();
        }

        private void SetSymbol(IDictionary<YamlNode, YamlNode> config)
        {
            ledOnSign = config.TryGetValue(configOnSymbolName, out var onSymbol) && onSymbol.ToString().Length == 1 ? $"[{onSymbol}]"
                : !string.IsNullOrEmpty(ledOnSign) ? ledOnSign : $"[{defaultOnSymbol}]";
            ledOffSign = config.TryGetValue(configOffSymbolName, out var offSymbol) && offSymbol.ToString().Length == 1 ? $"[{offSymbol}]"
                : !string.IsNullOrEmpty(ledOffSign) ? ledOffSign : $"[{defaultOffSymbol}]";

            if (config.TryGetValue(configOffSpaces, out var space))
            {
                var spacing = int.Parse(space.ToString()) > 0 ? int.Parse(space.ToString()) : 1;
                ledStatusWriteSpace = new string(' ', spacing);
                ledIndexWriteSpace = new string(' ', spacing + 2);
            }
            else
            {
                ledStatusWriteSpace = !string.IsNullOrEmpty(ledStatusWriteSpace) ? ledStatusWriteSpace : new string(' ', defaultspacing);
                ledIndexWriteSpace = !string.IsNullOrEmpty(ledIndexWriteSpace) ? ledIndexWriteSpace : new string(' ', defaultspacing + 2);
            }
        }

        public void SaveCurrentState()
        {
            var LedOnList = new List<string>();
            for (int i = 0; i < defaultLedCount; i++)
            {
                if (ledStatus[i])
                    LedOnList.Add(ledIndex[i]);
            }
            var saveLedOnText = string.Join(" ", LedOnList);
            File.WriteAllText(saveStatePath, saveLedOnText);
        }

        public void SetAppConfigurations(string onSymbol, string offSymbol, int spacing)
        {
            if (onSymbol == offSymbol) return;
            using (var writer = File.CreateText(configPath))
            {
                var newConfig = new YamlMappingNode();
                newConfig.Children.Add(configOnSymbolName, onSymbol);
                newConfig.Children.Add(configOffSymbolName, offSymbol);
                newConfig.Children.Add(configOffSpaces, spacing.ToString());
                var yaml = new YamlStream(new YamlDocument(newConfig));
                yaml.Save(writer, false);

                SetSymbol(newConfig.Children);
            }
        }

    }
}
