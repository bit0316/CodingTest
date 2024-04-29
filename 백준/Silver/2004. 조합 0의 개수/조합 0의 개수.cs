public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int result;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        result = GetResult(input[0], input[1]);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult(int numA, int numB)
    {
        int resultA;
        int resultB;

        resultA = GetDivideCount(numA, 2) - GetDivideCount(numB, 2) - GetDivideCount(numA - numB, 2);
        resultB = GetDivideCount(numA, 5) - GetDivideCount(numB, 5) - GetDivideCount(numA - numB, 5);

        return Math.Min(resultA, resultB);
    }

    static int GetDivideCount(int num, int div)
    {
        int count = 0;

        while (num >= div)
        {
            num /= div;
            count += num;
        }

        return count;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}