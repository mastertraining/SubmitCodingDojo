using System;
using Xunit;

namespace Homework11.Tests
{
    public class ConvertNumberToTextTest
    {
        [Theory]
        [InlineData(10, "�Ժ")]
        [InlineData(11,"�Ժ���")]
        [InlineData(1, "˹��")]
        [InlineData(0, "�ٹ��")]
        [InlineData(153, "˹����������Ժ���")]
        [InlineData(571, "����������Ժ���")]
        [InlineData(3234, "����ѹ�ͧ��������Ժ���")]
        [InlineData(7302, "�紾ѹ��������ͧ")]
        [InlineData(5045, "��Ҿѹ����Ժ���")]
        [InlineData(73000, "����������ѹ")]
        [InlineData(64327, "ˡ�������ѹ�����������Ժ��")]
        [InlineData(620000, "ˡ�ʹ�ͧ����")]
        [InlineData(876530, "Ỵ�ʹ������ˡ�ѹ�����������Ժ")]
        [InlineData(1234567, "˹����ҹ�ͧ�ʹ����������ѹ�������ˡ�Ժ��")]
        [InlineData(5800345, "�����ҹỴ�ʹ�����������Ժ���")]
        public void ConvertNumber10ToText(int input,string expected)
        {
            var sut = new Homework11();
            var actual = sut.GetReadWordOfNumber(input);
            Assert.Equal(expected, actual);
        }
    }
}
