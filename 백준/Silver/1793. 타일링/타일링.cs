using System.Numerics;

public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static Dictionary<int, int> left = new Dictionary<int, int>();
    static Dictionary<int, int> right = new Dictionary<int, int>();

    static void Main(string[] args)
    {
        BigInteger result;
        string input;

        while (true)
        {
            input = SR.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break;
            }

            result = GetResult(int.Parse(input));
            PrintResult(result);
        }

        SR.Close();
        SW.Close();
    }

    static BigInteger GetResult(int num)
    {
        BigInteger[] arr = new BigInteger[num + 3];

        arr[0] = 1;
        arr[1] = 1;
        arr[2] = 3;
        for (int i = 3; i <= num; ++i)
        {
            arr[i] = arr[i - 1] + arr[i - 2] * 2;
        }

        return arr[num];
    }

    static void PrintResult(BigInteger result)
    {
        SW.WriteLine(result);
    }
}