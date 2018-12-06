using System;
using System.Text;

public class Homework14 : IHomework14
{
    int size { get; set; }
    int disOdd { get; set; }
    int disEven { get; set; }
    int restOfOdd { get; set; }
    int restOfEven { get; set; }
    int ConsCounterOdd { get; set; }
    int ConsCounterEven { get; set; }

    public Homework14()
    {
        SetupANewGame();
    }

    string KooKeeDisplay() => new StringBuilder()
        .Append("Koo ").Append("(").Append(restOfEven.ToString()).Append("): ").AppendLine(new String('*', restOfEven))
        .Append("Kee ").Append("(").Append(restOfOdd.ToString()).Append("): ").Append(new string('*', restOfOdd)).ToString();

    public string GetGameResult(int number = 0)
    {
        var isEven = ((number & 1) == 0) ? true : false;

        if (number == 0)
        {
            return KooKeeDisplay();
        }

        else if (isEven)
        {
            EvenTurn();
        }
        else
        {
            OddTurn();
        }

        return KooKeeDisplay();
    }


    void EvenTurn()
    {
        restOfEven -= disEven;
        ConsCounterOdd = 0;
        ConsCounterEven += 1;
        if (ConsCounterEven == 3)
        {
            disOdd += 1;
            ConsCounterEven = 0;
        }
    }

    void OddTurn()
    {
        restOfOdd -= disOdd;
        ConsCounterEven = 0;
        ConsCounterOdd += 1;
        if (ConsCounterOdd == 3)
        {
            disEven += 1;
            ConsCounterOdd = 0;
        }
    }

    public void SetupANewGame()
    {
        size = 20;
        disOdd = disEven = 1;
        restOfEven = restOfOdd = size;
        ConsCounterOdd = ConsCounterEven = 0;
    }
}