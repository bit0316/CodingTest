public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());
    static int MAX_SIZE = 1000001;

    static long[] arr;

    static void Main(string[] args)
    {
        int size;
        int num;

        size = int.Parse(SR.ReadLine());
        arr = new long[MAX_SIZE];

        SetArray();
        for (int i = 0; i < size; ++i)
        {
            num = int.Parse(SR.ReadLine());
            PrintResult(arr[num]);
        }

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        for (int i = 1; i < MAX_SIZE; ++i)
        {
            for (int j = i; j < MAX_SIZE; j += i)
            {
                arr[j] += i;
            }
            arr[i] += arr[i - 1];
        }
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}