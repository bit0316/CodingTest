public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());
    
    static int[] arr;
    static int total;

    static void Main(string[] args)
    {
        SetArray();
        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        arr = new int[9];
        for (int i = 0; i < 9; ++i)
        {
            arr[i] = int.Parse(SR.ReadLine());
            total += arr[i];
        }
    }

    static void GetResult()
    {
        for (int i = 0; i < 8; ++i)
        {
            for (int j = i + 1; j < 9; ++j)
            {
                if (total - arr[i] - arr[j] == 100)
                {
                    arr[i] = int.MaxValue;
                    arr[j] = int.MaxValue;
                    Array.Sort(arr);
                    return;
                }
            }
        }
    }

    static void PrintResult()
    {
        for (int i = 0; i < 7; ++i)
        {
            SW.WriteLine(arr[i]);
        }
    }
}