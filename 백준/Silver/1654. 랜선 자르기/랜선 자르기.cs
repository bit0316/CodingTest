public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int count;
        long result;
        string[] input;

        input = SR.ReadLine().Split();
        size = int.Parse(input[0]);
        count = int.Parse(input[1]);

        result = GetBestDistance(size, count);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static long GetBestDistance(int size, int count)
    {
        long[] arr = new long[size];

        for (int i = 0; i < size; ++i)
        {
            arr[i] = long.Parse(SR.ReadLine());
        }

        return BinarySearch(arr, count);
    }

    static long BinarySearch(long[] arr, int count)
    {
        long min = 1;
        long max = arr.Max();
        long mid;
        long total;

        while (min <= max)
        {
            total = 0;
            mid = (min + max) / 2;

            foreach (long value in arr)
            {
                total += value / mid;
            }

            if (total >= count)
            {
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }

        return max;
    }

    static void PrintResult(long num)
    {
        SW.WriteLine(num);

        SW.Flush();
    }
}