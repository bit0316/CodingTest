public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int DAY_SEC = 24 * 60 * 60;
    static int MAX_SIZE = 3;

    static void Main(string[] args)
    {
        int result;
        string[] input;

        for (int i = 0; i < MAX_SIZE; ++i)
        {
            input = SR.ReadLine().Split();
            result = GetResult(input[0], input[1]);
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static int GetResult(string inputA, string inputB)
    {
        int[] timeA = Array.ConvertAll(inputA.Split(':'), int.Parse);
        int[] timeB = Array.ConvertAll(inputB.Split(':'), int.Parse);
        int secA = ((timeA[0] * 60) + timeA[1]) * 60 + timeA[2];
        int secB = ((timeB[0] * 60) + timeB[1]) * 60 + timeB[2];
        int timer = secA <= secB ? secB - secA : DAY_SEC + secB - secA;
        int count = 0;
        
        for (int i = 0; i <= timer; ++i)
        {
            if ((secA / 3600 * 10000 + secA / 60 * 100 + secA % 60) % 3 == 0)
            {
                count++;
            }
            secA++;
        }

        return count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}