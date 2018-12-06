using System;

namespace Homework14
{
    public class Homework14 : IHomework14
    {
        public int GoalDistance = 20;
        public int MaxRunStack = 3;
        public Runner Player1;
        public Runner Player2;

        public Homework14()
        {
            SetupANewGame();
        }

        public string GetGameResult(int number)
        {
            if(number%2 == 0)
            {
                var runBonus = Player1.BonusCount > 0 ? Player1.BonusCount : 0;
                Player1.RunStack++;
                Player1.RemainDistance -= 1 + runBonus;
                Player1.BonusCount = 0;
                if(Player1.RunStack == MaxRunStack)
                {
                    Player1.RunStack = 0;
                    Player2.BonusCount++;
                }
                return string.Format($"{new String('*', Player1.RemainDistance)}{Environment.NewLine}{new String('*', Player2.RemainDistance)}");
            }
            else
            {
                var runBonus = Player2.BonusCount > 0 ? Player2.BonusCount : 0;
                Player2.RunStack++;
                Player2.RemainDistance -= 1 + runBonus;
                Player2.BonusCount = 0;
                if (Player2.RunStack == MaxRunStack)
                {
                    Player2.RunStack = 0;
                    Player1.BonusCount++;
                }
                return string.Format($"{new String('*', Player1.RemainDistance)}{Environment.NewLine}{new String('*', Player2.RemainDistance)}");
            }
        }

        public void SetupANewGame()
        {
            Player1 = new Runner
            {
                Name = "Koo",
                RemainDistance = GoalDistance,
                BonusCount = 0,
                RunStack = 0
            };

            Player2 = new Runner
            {
                Name = "Kee",
                RemainDistance = GoalDistance,
                BonusCount = 0,
                RunStack = 0
            };
        }
    }

    public class Runner
    {
        public string Name { get; set; }
        public int RemainDistance { get; set; }
        public int RunStack { get; set; }
        public int BonusCount { get; set; }
        public bool IsWin { get; set; }
    }
}
