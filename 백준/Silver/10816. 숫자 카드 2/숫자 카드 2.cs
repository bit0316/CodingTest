public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());
    static int MAX = 20000000;

    static void Main(string[] args)
    {
        int sizeA;
        int sizeB;
        int[] arr;
        
        sizeA = int.Parse(SR.ReadLine());
        arr = new int[MAX + 1];
        SetArray(arr, sizeA);

        sizeB = int.Parse(SR.ReadLine());
        PrintResult(arr, sizeB);

        SR.Close();
        SW.Close();
    }

    static void SetArray(int[] arr, int size)
    {
        string[] input = SR.ReadLine().Split();

        for (int i = 0; i < size; ++i)
        {
            arr[MAX / 2 + int.Parse(input[i])]++;
        }
    }

    static int GetCount(int[] arr, int num)
    {
        return arr[MAX / 2 + num];
    }

    static void PrintResult(int[] arr, int size)
    {
        int count;
        string[] input = SR.ReadLine().Split();

        for (int i = 0; i < size; ++i)
        {
            count = GetCount(arr, int.Parse(input[i]));
            SW.Write($"{count} ");
        }

        SW.Flush();
    }
}