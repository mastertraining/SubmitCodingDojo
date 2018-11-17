using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_05
{
    public class Homework05 : IHomework05
    {
        private IList<string> LedIndex;
        private IList<string> ledStatus;
        private readonly int ledCount = 10;
        private readonly string ledOnSign = "[!]";
        private readonly string ledOffSign = "[ ]";
        private readonly string ledStatusWriteSpace = " ";
        private readonly string ledIndexWriteSpace = "   ";
        private IDictionary<int, string> ledIndexName = new Dictionary<int, string>();
        
        public Homework05() {
            RegisterIndexName();
            ledStatus = Enumerable.Repeat(ledOffSign, ledCount).ToList();
            LedIndex = Enumerable.Range(1, ledCount)
                .Select(it => ledIndexName.TryGetValue(it, out var value) ? value : it.ToString())
                .ToList();
        }

        private void RegisterIndexName() => ledIndexName.Add(10, "A");

        public string DisplayLEDOnScreen(string ledNo)
        {
            var index = LedIndex.IndexOf(ledNo);
            ledStatus[index] = ledStatus[index] == ledOffSign ? ledOnSign : ledOffSign;

            var eachLedStatus = string.Join(ledStatusWriteSpace, ledStatus);
            var eachLedIndex = string.Join(ledIndexWriteSpace, LedIndex);
            return $"{eachLedStatus}{Environment.NewLine} {eachLedIndex}";    
        }
    }
}
