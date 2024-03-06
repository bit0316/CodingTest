public class Program
{
    static void Main(string[] args)
    {
        int diceA;
        int diceB;
        int diceC;
        int reward = 0;
        string[] input;

        input = Console.ReadLine().Split();
        diceA = int.Parse(input[0]);
        diceB = int.Parse(input[1]);
        diceC = int.Parse(input[2]);

        if (diceA == diceB && diceB == diceC)
        {
            reward += 10000 + diceA * 1000;
        }
        else if (diceA == diceB || diceA == diceC)
        {
            reward += 1000 + diceA * 100;
        }
        else if (diceB == diceC)
        {
            reward += 1000 + diceB * 100;
        }
        else
        {
            if (diceA > diceB && diceA > diceC)
            {
                reward += diceA * 100;
            }
            else if (diceB > diceC && diceB > diceA)
            {
                reward += diceB * 100;
            }
            else
            {
                reward += diceC * 100;
            }
        }

        Console.WriteLine(reward);
    }
}