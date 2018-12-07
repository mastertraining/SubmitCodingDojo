using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework14
{
    public class Homework14 : IHomework14
    {
        public string RunnerEvenName { get; set; }
        public string RunnerOddName { get; set; }
        public int GoalDistance { get; set; }
        public int MaxRunStack { get; set; }
        public IEnumerable<Runner> RunnerList { get; set; }

        public Homework14()
        {
            RunnerEvenName = "Koo";
            RunnerOddName = "Kee";
            GoalDistance = 20;
            MaxRunStack = 3;
            SetupANewGame();
        }

        public string GetGameResult(int number)
        {
            var runnerName = number % 2 == 0 ? RunnerEvenName : RunnerOddName;
            UpdateRunnerInfo(runnerName);
            return DisplayGameResult();
        }

        public void SetupANewGame()
        {
            RunnerList = new List<Runner>
            {
                new Runner
                {
                    Name = RunnerEvenName,
                    RemainDistance = GoalDistance,
                    BonusDistance = 0,
                    RunStack = 0,
                    IsWin = false,
                },
                new Runner
                {
                    Name = RunnerOddName,
                    RemainDistance = GoalDistance,
                    BonusDistance = 0,
                    RunStack = 0,
                    IsWin = false,
                }
            };
        }

        public void UpdateRunnerInfo(string name)
        {
            var mainRunner = RunnerList.First(it => it.Name == name);
            var opponentRunner = name == RunnerEvenName ? RunnerList.First(it => it.Name == RunnerOddName) : RunnerList.First(it => it.Name == RunnerEvenName);
            var runBonus = mainRunner.BonusDistance > 0 ? mainRunner.BonusDistance : 0;
            mainRunner.RemainDistance -= 1 + runBonus;
            mainRunner.BonusDistance = 0;
            CheckRunInRow(mainRunner,opponentRunner);
            if (mainRunner.RemainDistance <= 0)
            {
                mainRunner.IsWin = true;
            }
        }

        public void CheckRunInRow(Runner mainRunner,Runner opponentRunner)
        {
            mainRunner.RunStack++;
            opponentRunner.RunStack = 0;
            if (mainRunner.RunStack == MaxRunStack)
            {
                mainRunner.RunStack = 0;
                opponentRunner.BonusDistance++;
            }
        }

        public string DisplayGameResult()
        {
            var builder = new StringBuilder();
            var evenRunner = RunnerList.First(it => it.Name == RunnerEvenName);
            var oddRunner = RunnerList.First(it => it.Name == RunnerOddName);
            var evenStar = evenRunner.RemainDistance > 0 ? new string('*', evenRunner.RemainDistance) : "";
            var oddStar = oddRunner.RemainDistance > 0 ? new string('*', oddRunner.RemainDistance) : "";
            builder
                .Append($"{evenRunner.Name}").Append($" ({evenRunner.RemainDistance}):").Append(evenStar).AppendLine()
                .Append($"{oddRunner.Name}").Append($" ({oddRunner.RemainDistance}):").Append(oddStar).AppendLine();
            if (evenRunner.IsWin || oddRunner.IsWin)
            {
                var winnerName = evenRunner.IsWin ? evenRunner.Name : oddRunner.Name;
                builder
                    .Append($"The Winner is MR.{winnerName}")
                    .AppendLine()
                    .Append("Do you want to try again?: ");
                SetupANewGame();
            }
            else
            {
                builder.Append("Please input a number: ");
            }
            return builder.ToString();
        }
    }

    public class Runner
    {
        public string Name { get; set; }
        public int RemainDistance { get; set; }
        public int RunStack { get; set; }
        public int BonusDistance { get; set; }
        public bool IsWin { get; set; }
    }
}
