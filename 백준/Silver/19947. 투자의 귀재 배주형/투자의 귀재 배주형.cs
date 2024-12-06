public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const float RATE_A = 1.05f;
    const float RATE_B = 1.20f;
    const float RATE_C = 1.35f;
    const int YEAR_MAX = 10;

    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int cost = input[0];
        int year = input[1];
        int result;

        result = GetResult(cost, year);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int cost, int year)
    {
        int[] arr = new int[YEAR_MAX + 1];
        for (int i = 0; i <= YEAR_MAX; ++i)
        {
            arr[i] = cost;
        }

        arr[1] = (int)(cost * 1.05);
        arr[2] = (int)(arr[1] * 1.05);
        arr[3] = (int)(cost * 1.2);
        arr[4] = (int)(arr[1] * 1.2);
        for (int i = 5; i <= year; ++i)
        {
            arr[i] = Math.Max((int)(arr[i - 1] * RATE_A), Math.Max((int)(arr[i - 3] * RATE_B), (int)(arr[i - 5] * RATE_C)));
        }

        return arr[year];
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}