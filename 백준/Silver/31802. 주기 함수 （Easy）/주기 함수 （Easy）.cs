public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int start, end;
        int[] input;
        long result;
        long[] arr;

        size = int.Parse(SR.ReadLine());
        arr = Array.ConvertAll(SR.ReadLine().Split(), long.Parse);
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        start = input[0];
        end = input[1];

        result = GetResult(size, arr, start, end);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static long GetResult(int size, long[] arr, int start, int end)
    {
        long result = 0;
        long sum = arr.Sum();
        int mid;

        mid = (end - start) / size;
        end -= mid * size;
        result += mid * sum;

        if (start < 0)
        {
            mid = (-start + size - 1) / size;
            start += mid * size;
            end += mid * size;
        }

        for (int i = start; i <= end - 1; ++i)
        {
            result += arr[i % size];
        }

        return result;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}