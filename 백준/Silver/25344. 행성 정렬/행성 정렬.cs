public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static long[] arr;

    static void Main(string[] args)
    {
        long result;

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

        arr = new long[size - 2];
        for (int i = 0; i < size - 2; ++i)
        {
            arr[i] = long.Parse(input[i]);
        }
    }

    static long GetResult()
    {
        long lcm = arr[0];

        for (int i = 1; i < size - 2; ++i)
        {
            lcm = GetLCM(lcm, arr[i]);
        }

        return lcm;
    }

    static long GetLCM(long numA, long numB)
    {
        (numA, numB) = numA > numB ? (numA, numB) : (numB, numA);

        return (numA * numB) / GetGCD(numA, numB);
    }

    static long GetGCD(long numA, long numB)
    {
        long remain = numA % numB;

        return remain != 0 ? GetGCD(numB, remain) : numB;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}