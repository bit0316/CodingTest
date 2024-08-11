public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int limit;
    static int[] arr;

    static void Main(string[] args)
    {
        int result;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];
        limit = input[1];

        SetArray();
        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        arr = new int[size];
        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(SR.ReadLine());
        }
    }

    static int GetResult()
    {
        int count;
        int result;
        
        result = 0;
        for (int i = 0; i < size; ++i)
        {
            count = 0;
            for (int j = 0; j < size; ++j)
            {
                if (arr[j] >= arr[i] && arr[j] - arr[i] <= limit)
                {
                    count++;
                }
            }
            result = Math.Max(result, count);
        }

        return result;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}