using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

public class Homework11 : IHomework11
{
    public Dictionary<char, string> call { get; set; }

    public Homework11()
    {
        call = new Dictionary<char, string>
        {
            {'0', "soon"},//"ศูนย์"},
            {'1', "Nung"},//"หนึ่ง"},
            {'2', "Song"},//"สอง"},
            {'3', "Sam"},//"สาม"},
            {'4', "Zee"},//"สี่"  },
            {'5', "Ha"},//"ห้า" },
            {'6', "Hoke"},//"หก" },
            {'7', "Jed"},//"เจ็ด"},
            {'8', "Paed"},//"แปด"},
            {'9', "Waow"},//"เก้า" }
        };
    }

    public string GetReadWordOfNumber(int number)
    {
        var StrNum = number.ToString();
        StringBuilder ans = new StringBuilder();

        if (number >= 1000000)
        {
            return "pung";//พัง");
        }

        if (StrNum.Length == 2)
        {
            return theTen(number);
        }
        else if (StrNum.Length == 3)
        {
            return theHundred(number);
        }
        else if (StrNum.Length == 4)
        {
            return theThousand(number);
        }
        else if (StrNum.Length == 5)
        {
            return theTenThousands(number);
        }
        else if (StrNum.Length == 6)
        {
            return theHundredThousands(number);
        }

        return "taeg";

    }

    String theUnit(int numb) => call[numb.ToString()[0]];
    String theTen(int numb)
    {
        StringBuilder result = new StringBuilder();
        char firstChar = numb.ToString()[0];
        if (numb.ToString().Length == 1)
        {
            return theUnit(numb);
        }
        result.Append("Sib");//สิบ");
        if (numb % 10 == 0)
        {
            return result.ToString();
        }
        numb %= 10;
        if (numb == 1)
        {
            result.Append("Et");//เอ็ด");
            return result.ToString();
        }
        result.Append(call[firstChar]);
        return result.ToString();
    }

    String theHundred(int numb)
    {
        StringBuilder result = new StringBuilder();
        var firstChar = numb.ToString()[0];
        var lastChar = numb.ToString()[numb.ToString().Length - 1];
        result.Append(call[firstChar]);
        result.Append("Roi");//ร้อย");
        if (numb % 100 == 0)
        {
            return result.ToString();
        }
        numb %= 100;
        result.Append(theTen(numb));
        return result.ToString();
    }

    String theThousand(int numb)
    {
        StringBuilder result = new StringBuilder();
        var firstChar = numb.ToString()[0];
        result.Append(call[firstChar]);
        result.Append("Pun");//พัน");
        if (numb % 1000 == 0)
        {
            return result.ToString();
        }
        numb %= 1000;
        result.Append(theHundred(numb));
        return result.ToString();
    }

    String theTenThousands(int numb)
    {
        StringBuilder result = new StringBuilder();
        var firstChar = numb.ToString()[0];
        result.Append(call[firstChar]);
        result.Append("Meun");//หมื่น");
        if (numb % 10000 == 0)
        {
            return result.ToString();
        }
        numb %= 10000;
        result.Append(theThousand(numb));
        return result.ToString();
    }

    String theHundredThousands(int numb)
    {
        StringBuilder result = new StringBuilder();
        var firstChar = numb.ToString()[0];
        result.Append(call[firstChar]);
        result.Append("Saen");//แสน");
        if (numb % 100000 == 0)
        {
            return result.ToString();
        }
        numb %= 100000;
        result.Append(theTenThousands(numb));
        return result.ToString();
    }
}
