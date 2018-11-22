using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_05
{
    public class Homework05 : IHomework05
    {
        private IList<string> ledIndex;
        private IList<string> ledStatus;
        private readonly int ledCount = 10;
        private readonly string ledOnSign = "[!]";
        private readonly string ledOffSign = "[ ]";
        private readonly string ledStatusWriteSpace = " ";
        private readonly string ledIndexWriteSpace = "   ";
        private IDictionary<int, string> ledIndexName = new Dictionary<int, string>();

        public Homework05()
        {
            RegisterIndexName();
            ledStatus = Enumerable.Repeat(ledOffSign, ledCount).ToList();
            ledIndex = Enumerable.Range(1, ledCount)
                .Select(it => ledIndexName.TryGetValue(it, out var value) ? value : it.ToString())
                .ToList();
        }

        private void RegisterIndexName() => ledIndexName.Add(10, "A");

        public string DisplayLEDOnScreen(string ledNo)
        {
            var index = ledIndex.IndexOf(ledNo);
            if (index != -1)
                ledStatus[index] = ledStatus[index] == ledOffSign ? ledOnSign : ledOffSign;
            var ledStatusWriteLine = string.Join(ledStatusWriteSpace, ledStatus);
            var ledIndexWriteLine = string.Join(ledIndexWriteSpace, ledIndex);
            return $"{ledStatusWriteLine}{Environment.NewLine} {ledIndexWriteLine}";
        }
    }
}
