public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int[] arr;
        long result;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            result = GetResult(arr);
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static long GetResult(int[] arr)
    {
        int length = arr.Length;
        long sum = 0;

        for (int i = 1; i < length - 1; ++i)
        {
            for (int j = i + 1; j < length; ++j)
            {
                sum += GetGCD(arr[i], arr[j]);
            }
        }

        return sum;
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