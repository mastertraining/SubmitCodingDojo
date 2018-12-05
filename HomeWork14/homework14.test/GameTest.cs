using System;
using homework14.lib;
using Xunit;

namespace homework14.test
{
    public class GameTest
    {
        [Fact]
        public void Test1()
        {
            var gameControl = new Homework14();
            var result = gameControl.GetGameResult(5);
            var expected = $"Koo (20): ********************{Environment.NewLine}Kee (19): *******************";
            Assert.Equal(expected, result);
            
            result = gameControl.GetGameResult(90);
            expected = $"Koo (19): *******************{Environment.NewLine}Kee (19): *******************";
            Assert.Equal(expected, result);
            
            result = gameControl.GetGameResult(3);
            expected = $"Koo (19): *******************{Environment.NewLine}Kee (18): ******************";
            Assert.Equal(expected, result);

            result = gameControl.GetGameResult(7);
            expected = $"Koo (19): *******************{Environment.NewLine}Kee (17): *****************";
            Assert.Equal(expected, result);

            result = gameControl.GetGameResult(9);
            expected = $"Koo (19): *******************{Environment.NewLine}Kee (16): ****************";
            Assert.Equal(expected, result);
        }
    }
}
