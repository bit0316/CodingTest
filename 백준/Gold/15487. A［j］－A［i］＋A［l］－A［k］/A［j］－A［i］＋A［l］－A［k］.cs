public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int result;
        int[] arr;

        size = int.Parse(SR.ReadLine());
        arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        result = GetResult(size, arr);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }
    static int GetResult(int size, int[] arr)
    {
        int min = arr[0];
        int max = int.MinValue;
        int diff = int.MinValue;
        int[] dp = new int[size - 3];

        for (int i = dp.Length - 1; i >= 0; --i)
        {
            dp[i] = int.MinValue;
        }

        for (int i = 1; i < size - 2; ++i)
        {
            dp[i - 1] = Math.Max(dp[i - 1], arr[i] - min);
            min = Math.Min(min, arr[i]);
        }

        min = arr[size - 1];
        for (int i = size - 2; i > 0; --i)
        {
            diff = Math.Max(diff, min - arr[i]);
            if (i >= 2)
            {
                max = Math.Max(max, dp[i - 2] + diff);
            }
            min = Math.Max(min, arr[i]);
        }


        return max;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}