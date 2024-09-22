public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int time;
        int walk;
        int result;
        int[] plum;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        time = input[0];
        walk = input[1];

        plum = SetPlum(time);
        result = GetResult(plum, time, walk);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int[] SetPlum(int size)
    {
        int[] plum = new int[size + 1];

        for (int i = 1; i <= size; ++i)
        {
            plum[i] = int.Parse(SR.ReadLine());
        }

        return plum;
    }

    static int GetResult(int[] plum, int time, int walk)
    {
        int[,,] dp = new int[3, time + 1, walk + 2];
        int result = 0;

        for (int i = 1; i <= time; ++i)
        {
            for (int j = 1; j <= walk + 1; ++j)
            {
                if (plum[i] == 1)
                {
                    dp[1, i, j] = Math.Max(dp[1, i - 1, j] + 1, dp[2, i - 1, j - 1] + 1);
                    dp[2, i, j] = Math.Max(dp[1, i - 1, j - 1], dp[2, i - 1, j]);
                }
                else if (i != 1 || j != 1)
                {
                    dp[1, i, j] = Math.Max(dp[2, i - 1, j - 1], dp[1, i - 1, j]);
                    dp[2, i, j] = Math.Max(dp[1, i - 1, j - 1] + 1, dp[2, i - 1, j] + 1);
                }
            }
        }

        for (int i = 1; i <= walk + 1; ++i)
        {
            result = Math.Max(result, Math.Max(dp[1, time, i], dp[2, time, i]));
        }

        return result;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}