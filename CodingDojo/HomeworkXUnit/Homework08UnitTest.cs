using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Homework_08;

namespace HomeworkXUnit
{
    public class Homework08UnitTest
    {
        private IHomework08 IHW;

        public Homework08UnitTest() => IHW = new Homework08();

        [Theory]
        [MemberData(nameof(GetTriangleShapeAsTextCase))]
        public void GetTriangleShapeAsTextShouldWork(int line, string expected)
        {
            var result = IHW.GetTriangleShapeAsText(line);
            result.Should().Be(expected);
        }

        public static IEnumerable<object[]> GetTriangleShapeAsTextCase => new List<object[]>
        {
            new object[]{
                1,$@"/|"
            },
            new object[]{
                2,$@" /|{Environment.NewLine}/_|"
            },
            new object[]{
                3,$@"  /|{Environment.NewLine} /_|{Environment.NewLine}/__|"
            },
            new object[]{
                4,$@"   /|{Environment.NewLine}  /_|{Environment.NewLine} /__|{Environment.NewLine}/___|"
            },
            new object[]{
                5,$@"    /|{Environment.NewLine}   /_|{Environment.NewLine}  /__|{Environment.NewLine} /___|{Environment.NewLine}/____|"
            },
        };
    }
}
