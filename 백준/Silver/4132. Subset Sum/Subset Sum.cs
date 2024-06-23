public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static long total;
    static int liter;
    static int size;
    static int result;
    static int[] arr;
    static int[] input;

    static void Main(string[] args)
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        liter = input[0];
        size = input[1];

        arr = new int[size];
        for (int i = 0; i < size; ++i)
        {
            arr[i] = int.Parse(SR.ReadLine());
        }

        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void GetResult()
    {
        result = int.MaxValue;
        total = 0;
        BackTracking(0);
    }

    static void BackTracking(int index)
    {
        if (liter <= total && total < result)
        {
            result = (int)total;
            return;
        }

        for (int i = index; i < size; ++i)
        {
            total += arr[i];
            BackTracking(i + 1);
            total -= arr[i];
        }
    }

    static void PrintResult()
    {
        if (result == int.MaxValue)
        {
            SW.WriteLine("IMPOSSIBLE");
        }
        else
        {
            SW.WriteLine(result);
        }
    }
}