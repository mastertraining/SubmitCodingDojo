using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using YamlDotNet.RepresentationModel;

namespace Homework.ConsoleApp
{
    public class Homework06 : IHomework06
    {
        public Dictionary<string, string> LED { get; set; }
        private string DisplayLED { get; set; }
        public string OnSymbol { get; set; }
        public string OffSymbol { get; set; }
        public string Spacing { get; set; }

        public string DisplayLEDOnScreen(string ledNo)
        {
            if (LED.ContainsKey(ledNo))
            {
                LED[ledNo] = (LED[ledNo] == $"[{OnSymbol}]") ? $"[{OffSymbol}]" : $"[{OnSymbol}]";
            }
            SetDisplayLED();
            return DisplayLED;
        }

        private void SetDisplayLED()
        {
            var spaces = new string(' ', int.Parse(Spacing));
            var ledValue = string.Join(spaces, LED.Values);
            var ledKeys = string.Join($"  {spaces}", LED.Keys);
            var displayLED = new StringBuilder();
            displayLED.AppendLine(ledValue).Append(" ").Append(ledKeys);
            DisplayLED = displayLED.ToString();
        }

        public string LoadState()
        {
            ReadYaml();
            SetLED();
            SetDisplayLED();
            return DisplayLED;
        }

        public void SaveCurrentState()
        {
            var values = new List<string>();
            foreach (var item in LED)
            {
                if (item.Value == $"[{OnSymbol}]")
                {
                    values.Add("1");
                }
                else
                {
                    values.Add("0");
                }
            }
            var CurrentState = new List<string>();
            CurrentState.Add(string.Join(',', values));
            CurrentState.Add(string.Join(',', LED.Keys));
            File.WriteAllLines(@"CurrentState.txt", CurrentState);
        }

        public void SetLED()
        {
            using (var fi = File.OpenText(@"CurrentState.txt"))
            {
                var states = new List<string>();
                string line;
                while ((line = fi.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        states.Add(line);
                    }
                }
                var state = states.ToArray();
                var values = state[0].Split(',');
                var keys = state[1].Split(',');
                LED = new Dictionary<string, string>();
                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i] == "1")
                    {
                        LED.Add(keys[i], $"[{OnSymbol}]");
                    }
                    else
                    {
                        LED.Add(keys[i], $"[{OffSymbol}]");
                    }
                }
            }
        }

        public void SetAppConfigurations(string onSymbol, string offSymbol, int spacing)
        {
            OnSymbol = onSymbol;
            OffSymbol = offSymbol;
            Spacing = spacing.ToString();
        }

        public void ReadYaml()
        {
            var ymalDoc = new YamlMappingNode();
            using (var reader = File.OpenText(@"config.yaml"))
            {
                var stream = new YamlStream();
                stream.Load(reader);
                ymalDoc = (YamlMappingNode)stream.Documents[0].RootNode;
            }
            var onSymbol = ymalDoc.Children.TryGetValue("on-symbol", out var tonSymbol) ? tonSymbol.ToString() : "!";
            var offSymbol = ymalDoc.Children.TryGetValue("off-symbol", out var toffSymbol) ? toffSymbol.ToString() : " ";
            var spacing = ymalDoc.Children.TryGetValue("spaces", out var tspacing) ? tspacing.ToString() : "1";
            SetAppConfigurations(onSymbol, offSymbol, int.Parse(spacing));
        }
    }
}