using System;
using System.Collections.Generic;

public class Homework12: IHomework12
{
    Dictionary<char, int> count { get; set; }

    public void CounterAlphabetInString(string input)
    {
        var len = input.Length;
        for (var i  = 0; i < len; ++i)
        {
            if (count.ContainsKey(input[i]))
            {
                count[input[i]]++;
            }
            else
            {
                count.Add(input[i], 1);
            }
        }
    }

    public char FirstDuplicateCharactor(string text)
    {
        count = new Dictionary<char, int>();
        CounterAlphabetInString(text);
        foreach(var item in count)
        {
            if (item.Value > 1)
            {
                return item.Key;
            }
        }
        return '-';
    }

    public char FirstNotDuplicateCharactor(string text)
    {
        count = new Dictionary<char, int>();
        CounterAlphabetInString(text);
        foreach (var item in count)
        {
            if (item.Value == 1)
            {
                return item.Key;
            }
        }
        return '-';
    }
}
