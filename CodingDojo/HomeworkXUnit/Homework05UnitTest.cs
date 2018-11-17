using FluentAssertions;
using Homework_05;
using Xunit;

namespace HomeworkXUnit
{
    public class Homework05UnitTest
    {
        private IHomework05 IHW;

        public Homework05UnitTest()
        {
            IHW = new Homework05();
        }
    }
}
