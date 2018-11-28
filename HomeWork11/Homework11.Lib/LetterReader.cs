using System;
using System.Collections.Generic;
using System.Text;

namespace Homework11.Lib
{
    public class LetterReader
    {
        public static Dictionary<string, string> MyLetterReader
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    {"0", "ศูนย์" },
                    {"1", "หนึ่ง" },
                    {"2", "สอง" },
                    {"3", "สาม"},
                    {"4", "สี่" },
                    {"5", "ห้า" },
                    {"6", "หก" },
                    {"7", "เจ็ด" },
                    {"8", "แปด" },
                    {"9", "เก้า" },
                    {"1*", "เอ็ด" }
                };
            }
        }

        public static Dictionary<string, string> MyDigitReader
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    {"*2", "สิบ" },
                    {"2*2", "ยี่" },
                    {"*3", "ร้อย" },
                    {"*4", "พัน" },
                    {"*5", "หมื่น" },
                    {"*6", "แสน" },
                    {"*7", "ล้าน" }
                };
            }
        }

        public static string SpecialOneKey { get { return "1*"; } }

        public static string SpecialTwentyKey { get { return "2*2"; } }
    }
}
