using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Homework_09;

namespace HomeworkXUnit
{
    public class Homework09UnitTest
    {
        private IHomework09 IHW;

        public Homework09UnitTest() => IHW = new Homework09(); 
    }
}
