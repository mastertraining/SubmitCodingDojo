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
            {'3', "sam"},//"สาม"},
            {'4', "zee"},//"สี่"  },
            {'5', "ha"},//"ห้า" },
            {'6', "hoke"},//"หก" },
            {'7', "jed"},//"เจ็ด"},
            {'8', "paed"},//"แปด"},
            {'9', "gaow"},//"เก้า" }
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

        return theHundredThousands(number);
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
            result.Append("et");//เอ็ด");
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
        result.Append("roi");//ร้อย");
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
        result.Append("pun");//พัน");
        if (numb % 1000 == 0)
        {
            return result.ToString();
        }
        numb %= 1000;
        result.Append(theTen(numb));
        return result.ToString();
    }

    String theTenThousands(int numb)
    {
        StringBuilder result = new StringBuilder();
        var firstChar = numb.ToString()[0];
        result.Append(call[firstChar]);
        result.Append("meun");//หมื่น");
        if (numb % 10000 == 0)
        {
            return result.ToString();
        }
        numb %= 10000;
        result.Append(theTen(numb));
        return result.ToString();
    }

    String theHundredThousands(int numb)
    {
        StringBuilder result = new StringBuilder();
        var firstChar = numb.ToString()[0];
        result.Append(call[firstChar]);
        result.Append("saen");//แสน");
        if (numb % 100000 == 0)
        {
            return result.ToString();
        }
        numb %= 100000;
        result.Append(theTen(numb));
        return result.ToString();
    }
}
