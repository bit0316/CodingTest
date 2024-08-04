public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int[] arr;

    static void Main(string[] args)
    {
        int result;

        size = int.Parse(SR.ReadLine());

        SetArray();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        string[] input = SR.ReadLine().Split();

        arr = new int[size];
        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(input[i]);
        }
    }

    static int GetResult()
    {
        int count = 2;
        int max = 2;

        for (int i = 0; i < size - 2; ++i)
        {
            if (arr[i] <= arr[i + 1] && arr[i + 1] <= arr[i + 2] ||
                arr[i] >= arr[i + 1] && arr[i + 1] >= arr[i + 2])
            {
                count = 2;
            }
            else
            {
                count++;
            }
            max = Math.Max(max, count);
        }

        return max;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}