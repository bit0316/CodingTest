public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int num;
        int result;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            num = int.Parse(SR.ReadLine());
            result = GetResult(num);
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static int GetResult(int size)
    {
        int[] start = new int[size];
        int[] arr = new int[size];
        int count = 0;

        for (int i = 0; i < size; ++i)
        {
            start[i] = i + 1;
        }

        string[] input = SR.ReadLine().Split();
        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(input[i]);
        }

        while (!IsValid(size, start, arr))
        {
            for (int i = 1; i < size; ++i)
            {
                if (arr[i] < arr[i - 1])
                {
                    (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
                    count++;
                }
            }
        }

        return count;
    }

    static bool IsValid(int size, int[] start, int[] arr)
    {
        for (int i = 0; i < size; i++)
        {
            if (start[i] != arr[i])
            {
                return false;
            }
        }
        return true;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}