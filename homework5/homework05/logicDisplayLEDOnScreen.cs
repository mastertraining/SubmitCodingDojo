using System;

namespace homework05
{
    public class logicDisplayLEDOnScreen : IHomework05
    {
        public string DisplayLEDOnScreen(string ledNo)
        {
           var switchh = new bool[] { false, false, false, false, false, false, false, false, false, false };
            var switchNo = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
            ledNo = ledNo.ToUpper();
            for (int i = 0; i < switchNo.Length; i++)
            {
                if (ledNo == switchNo [i])
                {
                    //switchh.Select(it => it ? "[!]" : "[ ]");
                   switchh[i] = !switchh[i];
                }
            }
             return "switchh";
             
               //TODO  ทำการบ้านยังไม่เสร็จนะคับ  
        }
    }


}