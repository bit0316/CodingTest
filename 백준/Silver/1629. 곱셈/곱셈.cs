public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int numA;
    static int numB;
    static int numC;
    static int[] input;

    static void Main(string[] args)
    {
        long result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        numA = input[0];
        numB = input[1];
        numC = input[2];

        result = GetResult(numA, numB, numC);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static long GetResult(int numA, int numB, int numC)
    {
        if (numB == 0)
        {
            return numA;
        }
        else if (numB == 1)
        {
            return numA % numC;
        }

        long half = GetResult(numA, numB / 2, numC);

        if (numB % 2 == 0)
        {
            return half * half % numC;
        }
        else
        {
            return half * half % numC * numA % numC;
        }
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}