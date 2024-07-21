using System.Numerics;

public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());


    static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int numA = input[0];
        int numB = input[1];
        BigInteger result;

        result = GetResult(numA, numB);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static BigInteger GetResult(int numA, int numB)
    {
        BigInteger result = 1;

        for (int i = 0; i < numB; ++i)
        {
            result *= numA - i;
            result /= i + 1;
        }

        return result;
    }

    static void PrintResult(BigInteger result)
    {
        SW.WriteLine(result);
    }
}