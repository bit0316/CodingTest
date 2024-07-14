public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MOD = 1000000007;

    static int size;
    static int[] heights;

    static void Main(string[] args)
    {
        long result;

        size = int.Parse(SR.ReadLine());
        heights = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static long GetResult()
    {
        long sum = 0;
        long temp;

        Array.Sort(heights);
        Array.Reverse(heights);
        for (int i = 0; i < size; ++i)
        {
            temp = sum + heights[i];
            sum = (sum + temp) % MOD;
        }

        return sum;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}