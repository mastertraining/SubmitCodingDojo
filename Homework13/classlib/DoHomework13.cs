using System;
using System.Linq;
using System.Collections.Generic;

public class DoHomework13 : IHomework13
{

    bool IsContain99(int numb)
    {
        var len = numb.ToString().Length;
        var Str = len < 6 ? numb.ToString() + new String('0', 6 - len) : numb.ToString();

        if (!(Str.Contains("99")))
        {
            return false;
        }

        if (Str[0] == '9' && Str[1] == '9' && Str[2] != '9')
        {
            return true;
        }

        if (Str[0] != '9' && Str[3] != '9' &&
            Str[1] == '9' && Str[2] == '9')
        {
            return true;
        }
        if (Str[1] != '9' && Str[4] != '9' &&
            Str[2] == '9' && Str[3] == '9')
        {
            return true;
        }
        if (Str[2] != '9' && Str[5] != '9' &&
            Str[3] == '9' && Str[4] == '9')
        {
            return true;
        }
        if (Str[3] != '9' && Str[4] == '9' && Str[5] == '9')
        {
            return true;
        }

        return false;
    }

    IEnumerable<int> ignoreImplossibleWay(IEnumerable<int> numbers) => numbers.Where(number =>
        !(
            number.ToString().Contains("9999") &&
            number.ToString().Contains("99999") &&
            number.ToString().Contains("999999")
        ));

    public int Homework13(IEnumerable<int> numbers)
    {
        var only99s = new List<int>();

        foreach (var numb in ignoreImplossibleWay(numbers))
        {
            if (IsContain99(numb))
            {
                Console.WriteLine(numb);
                only99s.Add(numb);
            }
        }

        return only99s.Count;
    }
}
