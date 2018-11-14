using System;

namespace Homework02.classlib
{
    public class StringSort  : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            // ตัดตัวเลขที่มี ,
            var split_number = text.Split(',');

            // วนลูปตัดเอาตัวเลข
            for (int i = 0; i < split_number.Length; i++)
            {
                // เก็บค่าที่วนลูปได้
                var convert_number = int.Parse(split_number[i]);

                // เอาค่าที่ได้มา x 11
                split_number[i] = (convert_number * 11).ToString();
            }

            // รวมตัวเลขที่ถูก x
            var join_number = string.Join(",\n\t",split_number);

            //เก็บค่า + ขึ้นบรรทัดใหม่ + tab
            var result = string.Format("[\n\t{0}\n]",join_number);

            return result;
        }
    }
}
