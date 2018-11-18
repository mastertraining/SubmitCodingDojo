using System;
using System.Linq;
using System.Text;

namespace homework05.lib
{
    public class Homework05 : IHomework05
    {
        private bool[] _leds;

        public Homework05()
        {
            _leds = new bool[10];
        }

        public string DisplayLEDOnScreen(string ledNo)
        {
            var isLedNoValid = !string.IsNullOrWhiteSpace(ledNo);
            if(!isLedNoValid) return RenderLeds();

            if (ledNo.Equals("a", StringComparison.CurrentCultureIgnoreCase)) ledNo = "10";
            if (int.TryParse(ledNo, out int ledNumber))
            {
                var isNumberValid = ledNumber > 0 && ledNumber < 11;
                if (!isNumberValid) return RenderLeds();

                var toggleLedNumber = ledNumber - 1;
                _leds[toggleLedNumber] = !_leds[toggleLedNumber];
            }
            return RenderLeds();
        }

        private string RenderLeds()
        {
            Func<bool, string> ConvertToLedFormat = (it) => it ? "[!]" : "[ ]";
            var render = new StringBuilder();

            var ledDisplay = _leds.Select(ConvertToLedFormat);
            var ledRow = string.Join(" ", ledDisplay);
            var numberRow = $"{Environment.NewLine} 1   2   3   4   5   6   7   8   9   A";

            render.Append(ledRow);
            render.Append(numberRow);
            return render.ToString();
        }
    }
}
