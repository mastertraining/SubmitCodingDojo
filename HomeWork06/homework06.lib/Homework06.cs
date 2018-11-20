using System;
using System.IO;
using System.Linq;
using System.Text;

namespace homework06.lib
{
    public class Homework06 : IHomework06
    {
        private const string FileName = @"config.yaml";
        private string _symbolOn;
        private string _symbolOff;
        private int _spaceDistanceAmount;
        private const int DefaultspaceDistanceAmount = 3;

        private bool[] _leds;

        public Homework06()
        {
            LoadState();
            _leds = new bool[10];
        }

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
            var result = string.Empty;
            if (!File.Exists(FileName)) CreateDefaultStateFile();
            using (var file = File.OpenText(FileName))
            {
                result = file.ReadToEnd();
                var textEachLine = result.Split('\n');
                for (int i = 0; i < textEachLine.Count(); i++)
                {
                    var value = textEachLine[i].Split(':').LastOrDefault().Trim();
                    switch (i)
                    {
                        case 0: _symbolOn = value; break;
                        case 1: _symbolOff = value; break;
                        case 2: _spaceDistanceAmount = int.Parse(value); break;
                        default: break;
                    }
                }
            }
            return result;
        }

        public void SaveCurrentState()
        {
            throw new NotImplementedException();
        }

        public void SetAppConfigurations(string onSymbol, string offSymbol, int spacing)
        {
            throw new NotImplementedException();
        }

        private string RenderLeds()
        {
            Func<bool, string> ConvertToLedFormat = (it) =>
            {
                var symbolOnDisplay = string.IsNullOrWhiteSpace(_symbolOn) ? " " : _symbolOn;
                var symbolOffDisplay = string.IsNullOrWhiteSpace(_symbolOff) ? " " : _symbolOff;
                return it ? $"[{symbolOnDisplay}]" : $"[{symbolOffDisplay}]";
            };

            var spaceLedAmount = new string(' ', _spaceDistanceAmount);
            var speaceLedNumberAmount = new string(' ', _spaceDistanceAmount - 1 > 0 ? DefaultspaceDistanceAmount + (_spaceDistanceAmount - 1) : DefaultspaceDistanceAmount);

            var ledDisplay = _leds.Select(ConvertToLedFormat);
            var ledRow = string.Join(spaceLedAmount, ledDisplay);
            var numberRow = $"{Environment.NewLine} 1{speaceLedNumberAmount}2{speaceLedNumberAmount}3{speaceLedNumberAmount}4{speaceLedNumberAmount}5{speaceLedNumberAmount}6{speaceLedNumberAmount}7{speaceLedNumberAmount}8{speaceLedNumberAmount}9{speaceLedNumberAmount}A";

            var render = new StringBuilder();
            render.Append(ledRow);
            render.Append(numberRow);
            return render.ToString();
        }

        private void CreateDefaultStateFile()
        {
            using (var file = File.Create(FileName))
            {
                var defaultState = new StringBuilder();
                defaultState.AppendLine("on-symbol : !")
                            .AppendLine("off-symbol :  ")
                            .AppendLine("spaces : 3");
                var info = new UTF8Encoding(true).GetBytes(defaultState.ToString());
                file.Write(info, 0, info.Length);
            }
        }
    }
}
