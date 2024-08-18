public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int result;

        size = int.Parse(SR.ReadLine());
        result = GetResult(size);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int size)
    {
        int index = -1;
        int max = -1;
        int num;

        for (int i = 1; i <= size; ++i)
        {
            num = GetMaxNum();
            if (num >= max)
            {
                max = num;
                index = i;
            }
        }

        return index;
    }

    static int GetMaxNum()
    {
        int[] arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int size = arr.Length;
        int max = 0;

        for (int i = 0; i < size - 2; ++i)
        {
            for (int j = i + 1; j < size - 1; ++j)
            {
                for (int k = j + 1; k < size; ++k)
                {
                    max = Math.Max(max, (arr[i] + arr[j] + arr[k]) % 10);
                }
            }
        }

        return max;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}