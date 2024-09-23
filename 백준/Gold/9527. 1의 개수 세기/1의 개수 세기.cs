public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static long[] arr;

    static void Main(string[] args)
    {
        long[] input = Array.ConvertAll(SR.ReadLine().Split(), long.Parse);
        long numA = input[0];
        long numB = input[1];
        long result;

        SetArray(100);
        result = GetResult(numA, numB);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetArray(int size)
    {
        arr = new long[size];
        for (int i = 1; i < size; ++i)
        {
            arr[i] = (long)Math.Pow(2, i - 1) + 2 * arr[i - 1];
        }

    }

    static long GetResult(long numA, long numB)
    {
        return GetCount(numB) - GetCount(numA - 1);
    }

    static long GetCount(long num)
    {
        string bin_num = Convert.ToString(num, 2);
        int size = bin_num.Length;
        long count = 0;
        int exp;

        for (int i = 0; i < size; i++)
        {
            if (bin_num[i] == '1')
            {
                exp = size - i - 1;
                count += arr[exp] + num - (long)Math.Pow(2, exp) + 1;
                num -= (long)Math.Pow(2, exp);
            }
        }

        return count;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}