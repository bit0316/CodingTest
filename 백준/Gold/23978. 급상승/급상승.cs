public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static List<long> days = new List<long>();
    static List<long> gaps = new List<long>();
    static long size, limit;

    const int SIZE_MAX = 1500000000;

    static void Main(string[] args)
    {
        string[] input;
        long result;

        input = SR.ReadLine().Split();
        size = long.Parse(input[0]);
        limit = long.Parse(input[1]);

        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static long GetResult()
    {
        string[] input;
        long num;

        input = SR.ReadLine().Split();
        for (long i = 0; i < size; ++i)
        {
            num = long.Parse(input[i]);
            days.Add(num);
            if (i != 0)
            {
                gaps.Add(num - days[(int)i - 1]);
            }
        }

        return BinarySearch();
    }

    static long Sum(long numA, long numB)
    {
        return (numA + numB) * (numA - numB + 1) / 2;
    }

    static bool IsValid(long num)
    {
        long sum = num * (num + 1) / 2;

        for (int i = 0; i < size - 1; ++i)
        {
            sum += Sum(num, Math.Max(0, num - gaps[i] + 1));
        }
        
        return sum >= limit;
    }

    static long BinarySearch()
    {
        long max = 0;
        long min = SIZE_MAX;
        long mid;

        while (max + 1 < min)
        {
            mid = (min + max) >> 1;
            if (IsValid(mid))
            {
                min = mid;
            }
            else
            {
                max = mid;
            }
        }

        return min;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}