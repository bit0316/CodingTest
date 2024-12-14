public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int COUNT_MAX = 64;

    static void Main(string[] args)
    {
        int size;
        long result;
        long[] arr;

        size = int.Parse(SR.ReadLine());
        arr = SetArray(size);
        result = GetResult(arr, COUNT_MAX - 1);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static long[] SetArray(int size)
    {
        long num;
        long[] arr = new long[COUNT_MAX];
        string[] input;

        input = SR.ReadLine().Split();
        for (int i = 0; i < size; ++i)
        {
            num = long.Parse(input[i]);
            if (num > 0)
            {
                arr[(int)Math.Log2(num)]++;
            }
        }

        return arr;
    }

    static long GetResult(long[] arr, int size)
    {
        int count = 0;
        for (int i = 0; i < size; ++i)
        {
            if (arr[i] > 0)
            {
                count = i;
            }
            arr[i + 1] += arr[i] / 2;
        }

        return (long)Math.Pow(2, count);
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}