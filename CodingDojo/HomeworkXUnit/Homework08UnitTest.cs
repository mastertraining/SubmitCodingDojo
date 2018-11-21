using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Homework_08;
using System.Diagnostics;

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
                1,$@"/|{Environment.NewLine}"
            },
            new object[]{
                2,$@" /|{Environment.NewLine}/_|{Environment.NewLine}"
            },
            new object[]{
                3,$@"  /|{Environment.NewLine} / |{Environment.NewLine}/__|{Environment.NewLine}"
            },
            new object[]{
                4,$@"   /|{Environment.NewLine}  / |{Environment.NewLine} /  |{Environment.NewLine}/___|{Environment.NewLine}"
            },
            new object[]{
                5,$@"    /|{Environment.NewLine}   / |{Environment.NewLine}  /  |{Environment.NewLine} /   |{Environment.NewLine}/____|{Environment.NewLine}"
            },
        };
    }
}
