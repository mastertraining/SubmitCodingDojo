using System;
using System.Text;
using System.Linq;

namespace Homework1.classlib
{
    public class StringSort : MyTextSorting
    {
        public string SortByAlphabetical(string text)
        {
            // สร้างตัวแปรเพื่อเรียกใช้ StringBuilder
            var builder = new StringBuilder();

            // ตัดเอาคำที่มี , เช่น without,hello,
            var SplitString = text.Split(',');

            // เก็บค่าที่ถูกตัด without hello
            var result = SplitString.OrderBy(it => it);

            // รวมคำแล้วต่อด้วย ,
            var JoinString = String.Join(",",result);

            return builder.Append(JoinString).ToString();

        }

    }
}
