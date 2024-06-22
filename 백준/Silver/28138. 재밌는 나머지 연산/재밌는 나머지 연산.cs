public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        long[] input;
        long result;

        input = Array.ConvertAll(SR.ReadLine().Split(), long.Parse);
        result = GetResult(input[0], input[1]);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static long GetResult(long numA, long numB)
    {
        long result = 0;

        numA -= numB;
        for (int i = 1; i <= Math.Sqrt(numA); i++)
        {
            if (numA % i == 0)
            {
                if (i > numB)
                {
                    result += i;
                }
                if (i * i != numA && numA / i > numB)
                {
                    result += numA / i;
                }
            }
        }
        return result;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}