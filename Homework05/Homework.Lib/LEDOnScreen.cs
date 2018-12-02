using System;

namespace Homework.Lib {
    public class LEDOnScreen : IHomework05 {
        public string[] LED = new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
        public string DisplayLEDOnScreen (string ledNo) {
            string[] nameLed = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
            for (int i = 0; i < nameLed.Length; i++) {
                if (ledNo == nameLed[i]) {
                    if (LED[i] == "[ ]") {
                        LED[i] = "[!]";
                    } else {
                        LED[i] = "[ ]";
                    }
                    return string.Join(" ",LED);
                }
            }
            return string.Join(" ",LED).ToString();
        }
    }
}