public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int count;
    static int[] arr;
    static int[] input;

    static void Main(string[] args)
    {
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];
        count = input[1];
        arr = new int[size + 1];

        SetArray();
        for (int i = 0; i < count; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            result = GetResult(input[0], input[1]);
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static void SetArray()
    {
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        for (int i = 1; i <= size; ++i)
        {
            arr[i] = arr[i - 1] + input[i - 1];
        }
    }

    static int GetResult(int numA, int numB)
    {
        return arr[numB] - arr[numA - 1];
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}