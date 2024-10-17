public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int count;
        int result;
        int[] input;
        int[][] arr;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];
        count = input[1];

        arr = SetArray(size);
        result = GetResult(size, count, arr);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int[][] SetArray(int size)
    {
        int[][] arr = new int[size][];

        for (int i = 0; i < size; ++i)
        {
            arr[i] = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        }

        return arr;
    }

    static int GetResult(int size, int count, int[][] arr)
    {
        int[] pick = new int[count];
        int max = int.MinValue;

        for (int i = 0; i < size; ++i)
        {
            max = Math.Max(max, BackTracking(0, i, size, count, pick, arr));
        }

        return max;
    }

    static int BackTracking(int depth, int index, int size, int count, int[] pick, int[][] arr)
    {
        if (depth == count)
        {
            return GetSum(count, pick, arr);
        }

        int max = int.MinValue;

        pick[depth] = index;
        for (int i = index; i < size; ++i)
        {
            max = Math.Max(max, BackTracking(depth + 1, i + 1, size, count, pick, arr));
        }

        return max;
    }

    static int GetSum(int count, int[] pick, int[][] arr)
    {
        int sum = 0;

        for (int i = 0; i < count; ++i)
        {
            for (int j = i + 1; j < count; ++j)
            {
                sum += arr[pick[i]][pick[j]];
            }
        }

        return sum;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}