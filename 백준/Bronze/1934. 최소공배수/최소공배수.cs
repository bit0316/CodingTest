public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int[] arr;

        size = int.Parse(SR.ReadLine());
        arr = new int[size];

        GetArray(arr, size);
        PrintResult(arr);

        SR.Close();
        SW.Close();
    }

    static void GetArray(int[] arr, int size)
    {
        int numA;
        int numB;
        string[] input;

        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();
            numA = int.Parse(input[0]);
            numB = int.Parse(input[1]);
            arr[i] = GetLCM(numA, numB);
        }
    }

    static int GetLCM(int numA, int numB)
    {
        (numA, numB) = numA > numB ? (numA, numB) : (numB, numA);

        return (numA * numB) / GetGCD(numA, numB);
    }

    static int GetGCD(int numA, int numB)
    {
        int remain = numA % numB;

        return remain != 0 ? GetGCD(numB, remain) : numB;
    }

    static void PrintResult(int[] arr)
    {
        int size = arr.Length;

        for (int i = 0; i < size; ++i)
        {
            SW.WriteLine(arr[i]);
        }

        SW.Flush();
    }
}