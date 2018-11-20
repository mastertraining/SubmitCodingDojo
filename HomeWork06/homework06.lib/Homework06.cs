using System;
using System.IO;
using System.Linq;
using System.Text;

namespace homework06.lib
{
    public class Homework06 : IHomework06
    {
        private const string FileName = @"config.yaml";
        private string _onSymbol;
        private string _offSymbol;
        private int _spaceDistance;
        private const int DefaultspaceDistanceAmount = 3;

        private bool[] _leds;

        public Homework06() => _leds = new bool[10];

        public string DisplayLEDOnScreen(string ledNo)
        {
            var isLedNoValid = !string.IsNullOrWhiteSpace(ledNo);
            if (!isLedNoValid) return RenderLeds();

            int.TryParse(ledNo, out int ledNumber);
            var isSpecialAlphabet = ledNo.Equals("a", StringComparison.CurrentCultureIgnoreCase);
            var isNumberValid = ledNumber > 0 && ledNumber < 10;
            if (!isNumberValid && !isSpecialAlphabet) return RenderLeds();

            if (isSpecialAlphabet) ledNumber = 10;
            var toggleLedNumber = ledNumber - 1;
            _leds[toggleLedNumber] = !_leds[toggleLedNumber];
            return RenderLeds();
        }

        public string LoadState()
        {
            if (!File.Exists(FileName)) CreateDefaultStateFile();
            using (var file = File.OpenText(FileName))
            {
                var onSymbol = string.Empty;
                var offSymbol = string.Empty;
                var spacing = 0;

                var text = file.ReadToEnd();
                var textEachLine = text.Split('\n');
                var ledIndex = 0;
                foreach (var item in textEachLine)
                {
                    if (item.Contains("on-symbol : "))
                    {
                        var value = item.Split(':').LastOrDefault().Trim();
                        var symbol = string.IsNullOrWhiteSpace(value) ? " " : value;
                        onSymbol = symbol;
                    }
                    else if (item.Contains("off-symbol : "))
                    {
                        var value = item.Split(':').LastOrDefault().Trim();
                        var symbol = string.IsNullOrWhiteSpace(value) ? " " : value;
                        offSymbol = symbol;
                    }
                    else if (item.Contains("spaces : "))
                    {
                        var value = item.Split(':').LastOrDefault().Trim();
                        spacing = int.Parse(value);
                    }
                    else if (item.Contains(","))
                    {
                        var itemSplited = item.Split(',');
                        var ledNumbers = itemSplited.FirstOrDefault().Split(':').LastOrDefault();
                        var ledValue = itemSplited.LastOrDefault().Split(':').LastOrDefault();
                        _leds[ledIndex] = ledValue.ToLower().Contains("true");
                        ledIndex++;
                    }
                }
                SetAppConfigurations(onSymbol, offSymbol, spacing);
            }
            return RenderLeds();
        }

        public void SaveCurrentState() => CreateOrReplaceStateFile(false);

        public void SetAppConfigurations(string onSymbol, string offSymbol, int spacing)
        {
            this._onSymbol = onSymbol;
            this._offSymbol = offSymbol;
            this._spaceDistance = spacing;
        }

        private string RenderLeds()
        {
            Func<bool, string> ConvertToLedFormat = (it) =>
            {
                var symbolOnDisplay = string.IsNullOrWhiteSpace(_onSymbol) ? " " : _onSymbol;
                var symbolOffDisplay = string.IsNullOrWhiteSpace(_offSymbol) ? " " : _offSymbol;
                return it ? $"[{symbolOnDisplay}]" : $"[{symbolOffDisplay}]";
            };

            var spaceLedAmount = new string(' ', _spaceDistance);
            var speaceLedNumberAmount = new string(' ', _spaceDistance - 1 > 0 ? DefaultspaceDistanceAmount + (_spaceDistance - 1) : DefaultspaceDistanceAmount);

            var ledDisplay = _leds.Select(ConvertToLedFormat);
            var ledRow = string.Join(spaceLedAmount, ledDisplay);
            var numberRow = $"{Environment.NewLine} 1{speaceLedNumberAmount}2{speaceLedNumberAmount}3{speaceLedNumberAmount}4{speaceLedNumberAmount}5{speaceLedNumberAmount}6{speaceLedNumberAmount}7{speaceLedNumberAmount}8{speaceLedNumberAmount}9{speaceLedNumberAmount}A";

            var render = new StringBuilder();
            render.Append(ledRow);
            render.Append(numberRow);
            return render.ToString();
        }

        private void CreateDefaultStateFile() => CreateOrReplaceStateFile(true);

        private void CreateOrReplaceStateFile(bool isCreate)
        {
            using (var file = File.Create(FileName))
            {
                var onSymbol = isCreate ? "!" : _onSymbol;
                var offSymbol = isCreate ? " " : _offSymbol;
                var spaces = isCreate ? "1" : _spaceDistance.ToString();
                var leds = isCreate ? new[] { false, false, false, false, false, false, false, false, false, false } : _leds;

                var defaultState = new StringBuilder();
                defaultState.AppendLine($"on-symbol : {onSymbol}")
                            .AppendLine($"off-symbol : {offSymbol}")
                            .AppendLine($"spaces : {spaces}")
                            .AppendLine("leds : ");
                for (int i = 0; i < leds.Count(); i++)
                {
                    var ledNumber = i + 1;
                    var number = (ledNumber >= leds.Count()) ? "A" : ledNumber.ToString();
                    defaultState.AppendLine($"\t- {{ number : {number}, value : {_leds[i]} }}");
                }
                var info = new UTF8Encoding(true).GetBytes(defaultState.ToString());
                file.Write(info, 0, info.Length);
            }
        }
    }
}
