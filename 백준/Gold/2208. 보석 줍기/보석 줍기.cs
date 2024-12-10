public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int count;
        int limit;
        int result;
        int[] arr;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        count = input[0];
        limit = input[1];

        arr = SetArray(count);
        result = GetResult(count, limit, arr);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int[] SetArray(int size)
    {
        int[] arr = new int[size + 1];

        for (int i = 1; i <= size; ++i)
        {
            arr[i] = arr[i - 1] + int.Parse(SR.ReadLine());
        }

        return arr;
    }

    static int GetResult(int count, int limit, int[] arr)
    {
        int[] dp = new int[count + 1];
        int max = int.MinValue;

        dp[limit] = arr[limit];
        for (int i = limit + 1; i <= count; ++i)
        {
            dp[i] = Math.Max(dp[i - 1] + arr[i] - arr[i - 1], arr[i] - arr[i - limit]);
        }

        for (int i = limit; i <= count; ++i)
        {
            max = Math.Max(max, dp[i]);
        }

        return max;
    }


    static void PrintResult(int result)
    {
        SW.WriteLine(result < 0 ? 0 : result);
    }
}