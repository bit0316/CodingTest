public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int numA;
        int numB;
        int result;
        string[] input;

        input = SR.ReadLine().Split();
        numA = int.Parse(input[0]);
        numB = int.Parse(input[1]);
        result = GetBinomialCoefficient(numA, numB);

        PrintResult(result);
        SR.Close();
        SW.Close();
    }

    static int GetBinomialCoefficient(int numA, int numB)
    {
        int numerator = 1;
        int denominator = 1;

        numB = numA - numB > numB ? numB : numA - numB;
        for (int i = 1; i <= numB; ++i)
        {
            numerator *= numA--;
            denominator *= i;
        }

        return numerator / denominator;
    }

    static void PrintResult(int num)
    {
        SW.WriteLine(num);

        SW.Flush();
    }
}