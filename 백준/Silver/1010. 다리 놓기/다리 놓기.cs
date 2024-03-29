public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int west;
        int east;
        long count;
        string[] input;

        size = int.Parse(SR.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();
            west = int.Parse(input[0]);
            east = int.Parse(input[1]);
            count = GetCaseCount(west, east);
            PrintResult(count);
        }

        SR.Close();
        SW.Close();
    }

    static long GetCaseCount(int west, int east)
    {
        int count = east > west * 2 ? west : east - west;
        long numerator = 1;
        long denominator = 1;

        for (int i = 1; i <= count; ++i)
        {
            numerator *= east - i + 1;
            denominator *= i;
        }

        return (long)(numerator / denominator);
    }

    static void PrintResult(long value)
    {
        SW.WriteLine(value);
    }
}