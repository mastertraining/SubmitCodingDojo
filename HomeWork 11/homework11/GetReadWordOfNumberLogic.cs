using System;
using System.Linq;

namespace homework11
{
    public class GetReadWordOfNumberLogic : IHomework11
    {
        public string GetReadWordOfNumber(int number)
        {           
            if (number == 0)
            {
                return "ศูนย์";
            }
            else if (number == 1)
            {
                return "หนึ่ง";
            }
            else if (number == 2)
            {
                return "สอง";
            }
            else if (number == 3)
            {
                return "สาม";
            }
            else if (number == 4)
            {
                return "สี่";
            }
            else if (number == 5)
            {
                return "ห้า";
            }
            else if (number == 6)
            {
                return "หก";
            }
            else if (number == 7)
            {
                return "เจ็ด";
            }
            else if (number == 8)
            {
                return "แปด";
            }
            else if (number == 9)
            {
                return "เก้า";
            }
            else
            {
                return "please in put a number only!";
            }
            
        }
    }
}
