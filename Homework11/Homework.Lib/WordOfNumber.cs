using System;
using System.Text;

namespace Homework.Lib {
    public class WordOfNumber : IHomework11 {
        public string GetReadWordOfNumber (int number) {
            int[] point = new int[] { 1000000, 100000, 10000, 1000, 100, 10, 1 };
            string[] word = new string[] { "ล้าน", "แสน", "หมื่น", "พัน", "ร้อย", "สิบ", string.Empty };
            var sorry = new StringBuilder ();
            var result = string.Empty;
            for (int i = 0; i < point.Length; i++) {
                var devic = ChangeToWord (number / point[i]);

                if (point[i] == point[6] && devic == "หนึ่ง") {
                    devic = "เอ็ด";
                }
                if (point[i] == point[5] && devic == "หนึ่ง") {
                    devic = string.Empty;
                }
                if (point[i] == point[5] && devic == "สอง") {
                    devic = "ยี่";
                }
                if ((number / point[i]) != 0) {
                    result = sorry.Append (devic).Append (word[i]).ToString ();
                }
                number = number % point[i];
            }
            return result;
        }

        public string ChangeToWord (int text) {
            switch (text) {
                case 1:
                    return "หนึ่ง";
                case 2:
                    return "สอง";
                case 3:
                    return "สาม";
                case 4:
                    return "สี่";
                case 5:
                    return "ห้า";
                case 6:
                    return "หก";
                case 7:
                    return "เจ็ด";
                case 8:
                    return "แปด";
                case 9:
                    return "เก้า";
                default:
                    return "ศูนย์";
            }
        }
    }
}