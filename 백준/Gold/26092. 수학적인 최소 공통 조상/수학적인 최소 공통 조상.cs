public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    const int SIZE_MAX = 1000000;

    static void Main(string[] args)
    {
        long[] input = Array.ConvertAll(SR.ReadLine().Split(), long.Parse);
        long numA = input[0];
        long numB = input[1];

        while (numA != numB)
        {
            if (numA > numB)
            {
                numA = FindParent(numA);
            }
            else
            {
                numB = FindParent(numB);
            }
        }
        PrintResult(numA);

        SR.Close();
        SW.Close();
    }

    static long FindParent(long num)
    {
        for (int i = 2; i <= SIZE_MAX; ++i)
        {
            if (num % i == 0)
            {
                return num / i;
            }
        }
        return 1;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}