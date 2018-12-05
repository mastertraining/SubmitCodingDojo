using System;
using homework14.lib;
using Xunit;

namespace homework14.test
{
    public class GameTest
    {
        [Theory(DisplayName = "Give even number, system should calculate correct")]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(16)]
        [InlineData(50)]
        [InlineData(100)]
        public void GameCalculate_EvenNumber(int number)
        {
            var gameControl = new Homework14();
            var result = gameControl.GetGameResult(number);
            var expected = $"Koo (19): *******************{Environment.NewLine}Kee (20): ********************";
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "Give odd number, system should calculate correct")]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(9)]
        [InlineData(27)]
        [InlineData(99)]
        public void GameCalculate_OddNumber(int number)
        {
            var gameControl = new Homework14();
            var result = gameControl.GetGameResult(number);
            var expected = $"Koo (20): ********************{Environment.NewLine}Kee (19): *******************";
            Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "Game calculate correct a whole game is running (Player1 won)")]
        public void GameCalculate_Player1Won()
        {
            var gameControl = new Homework14();
            var result = gameControl.GetGameResult(2);
            var expected = $"Koo (19): *******************{Environment.NewLine}Kee (20): ********************";
            Assert.Equal(expected, result);

            result = gameControl.GetGameResult(37);
            expected = $"Koo (19): *******************{Environment.NewLine}Kee (19): *******************";
            Assert.Equal(expected, result);

            result = gameControl.GetGameResult(4);
            expected = $"Koo (18): ******************{Environment.NewLine}Kee (19): *******************";
            Assert.Equal(expected, result);

            result = gameControl.GetGameResult(8);
            expected = $"Koo (17): *****************{Environment.NewLine}Kee (19): *******************";
            Assert.Equal(expected, result);

            result = gameControl.GetGameResult(12);
            expected = $"Koo (16): ****************{Environment.NewLine}Kee (19): *******************";
            Assert.Equal(expected, result);

            result = gameControl.GetGameResult(3);
            expected = $"Koo (16): ****************{Environment.NewLine}Kee (17): *****************";
            Assert.Equal(expected, result);

            for (int i = 0; i < 14; i++) result = gameControl.GetGameResult(2);

            result = gameControl.GetGameResult(2);
            expected = $"Koo (01): *{Environment.NewLine}Kee (17): *****************";
            Assert.Equal(expected, result);

            result = gameControl.GetGameResult(3);
            expected = $"Koo (01): *{Environment.NewLine}Kee (10): **********";
            Assert.Equal(expected, result);

            result = gameControl.GetGameResult(2);
            expected = $"Koo (00): {Environment.NewLine}Kee (10): **********{Environment.NewLine}The Winner is MR.Koo";
            Assert.Equal(expected, result);

            gameControl.SetupANewGame();
            result = gameControl.GetGameResult(2);
            expected = $"Koo (19): *******************{Environment.NewLine}Kee (20): ********************";
            Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "Game calculate correct a whole game is running (Player2 won)")]
        public void GameCalculate_Player2Won()
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

            result = gameControl.GetGameResult(2);
            expected = $"Koo (17): *****************{Environment.NewLine}Kee (16): ****************";
            Assert.Equal(expected, result);

            for (int i = 0; i < 14; i++) result = gameControl.GetGameResult(3);

            result = gameControl.GetGameResult(3);
            expected = $"Koo (17): *****************{Environment.NewLine}Kee (01): *";
            Assert.Equal(expected, result);

            result = gameControl.GetGameResult(2);
            expected = $"Koo (10): **********{Environment.NewLine}Kee (01): *";
            Assert.Equal(expected, result);

            result = gameControl.GetGameResult(1);
            expected = $"Koo (10): **********{Environment.NewLine}Kee (00): {Environment.NewLine}The Winner is MR.Kee";
            Assert.Equal(expected, result);

            gameControl.SetupANewGame();
            result = gameControl.GetGameResult(5);
            expected = $"Koo (20): ********************{Environment.NewLine}Kee (19): *******************";
            Assert.Equal(expected, result);
        }
    }
}
