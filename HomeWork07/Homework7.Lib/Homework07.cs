﻿using Homework7.Lib.Contract;
using System;
using System.Linq;

namespace Homework7.Lib
{
    public class Homework07 : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var arrayStringWithRemoveAndOrder = text.Split(' ').OrderBy(it => it).Distinct();
            return string.Join(' ', arrayStringWithRemoveAndOrder);
        }
    }
}
