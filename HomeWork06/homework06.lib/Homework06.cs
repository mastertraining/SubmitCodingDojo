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
        private int _spacingDistanceAmount;
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

                var textEachLine = file.ReadToEnd().Split('\n');
                var ledIndex = 0;
                foreach (string item in textEachLine)
                {
                    var isLedValue = item.StartsWith("\t- { ") &&
                                     item.Contains(",") &&
                                     item.Contains("number : ") &&
                                     item.Contains("value : ");
                    if (isLedValue)
                    {
                        System.Console.WriteLine("Item: " + item);
                        System.Console.WriteLine("IsEndWith: " + item.EndsWith(" }"));

                        var itemSplited = item.Split(',');
                        var ledNumbers = itemSplited.FirstOrDefault().Split(':').LastOrDefault();
                        var ledValue = itemSplited.LastOrDefault().Split(':').LastOrDefault();
                        _leds[ledIndex] = ledValue.ToLower().Contains("true");
                        ledIndex++;
                    }
                    else
                    {
                        var textValue = item.Split(':').LastOrDefault().Trim();
                        if (item.Contains("spaces : "))
                        {
                            spacing = int.Parse(textValue);
                            continue;
                        }

                        var value = string.IsNullOrWhiteSpace(textValue) ? " " : textValue;
                        if (item.Contains("on-symbol : ")) onSymbol = value;
                        else if (item.Contains("off-symbol : ")) offSymbol = value;
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
            this._spacingDistanceAmount = spacing;
        }

        private string RenderLeds()
        {
            Func<bool, string> ConvertToLedFormat = (isOnSymbol) =>
            {
                var onSymbolDisplay = !string.IsNullOrWhiteSpace(_onSymbol) ? _onSymbol : " ";
                var offSymbolDisplay = !string.IsNullOrWhiteSpace(_offSymbol) ? _offSymbol : " ";
                return isOnSymbol ? $"[{onSymbolDisplay}]" : $"[{offSymbolDisplay}]";
            };

            var spaceLedAmount = new string(' ', _spacingDistanceAmount);
            var spacingCalculate = _spacingDistanceAmount - 1;
            var speacingLedNumberAmount = spacingCalculate > 0 ? DefaultspaceDistanceAmount + spacingCalculate : DefaultspaceDistanceAmount;
            var spacingLedNumber = new string(' ', speacingLedNumberAmount);

            var ledDisplay = _leds.Select(ConvertToLedFormat);
            var ledRow = string.Join(spaceLedAmount, ledDisplay);

            var render = new StringBuilder();
            render.AppendLine(ledRow);
            for (int i = 0; i < _leds.Count(); i++)
            {
                var ledNumber = i + 1;
                var isFirstNumber = ledNumber == 1;
                var ledNumberDisplay = ledNumber >= _leds.Count() ? "A" : ledNumber.ToString();
                var number = isFirstNumber ? ledNumberDisplay.PadLeft(2) : ledNumberDisplay;
                render.Append($"{number}{spacingLedNumber}");
            }
            return render.ToString();
        }

        private void CreateDefaultStateFile() => CreateOrReplaceStateFile(true);

        private void CreateOrReplaceStateFile(bool isCreate)
        {
            using (var file = File.Create(FileName))
            {
                var onSymbol = isCreate ? "!" : _onSymbol;
                var offSymbol = isCreate ? " " : _offSymbol;
                var spaces = isCreate ? "1" : _spacingDistanceAmount.ToString();
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
