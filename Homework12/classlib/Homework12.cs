using System;
using System.Collections.Generic;

public class Homework12 : IHomework12
{
    Dictionary<char, int> count { get; set; }

    public void CounterAlphabetInString(string input)
    {
        foreach (var i in input)
        {
            if (count.ContainsKey(i))
            {
                count[i]++;
            }
            else
            {
                count.Add(i, 1);
            }
        }
    }

    public char FirstDuplicateCharactor(string text)
    {
        count = new Dictionary<char, int>();
        CounterAlphabetInString(text);
        foreach (var item in count)
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
