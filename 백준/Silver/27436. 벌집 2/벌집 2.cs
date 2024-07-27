public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static long MAX_NUM = 2000000000;

    static void Main(string[] args)
    {
        long num;
        long result;

        num = long.Parse(SR.ReadLine());

        result = GetResult(num);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static long GetResult(long num)
    {
        long left = 1;
        long right = MAX_NUM;
        long mid;

        while (left < right)
        {
            mid = (left + right) / 2;
            if (3 * mid * (mid - 1) + 1 < num)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return left;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}