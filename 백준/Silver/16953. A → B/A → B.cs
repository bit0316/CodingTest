public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int numA;
    static int numB;

    static void Main(string[] args)
    {
        int result;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        numA = input[0];
        numB = input[1];

        result = GetResult();
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static int GetResult()
    {
        int count = 1;
        while (numA < numB)
        {
            if (numB % 10 == 1)
            {
                numB /= 10;
            }
            else if (numB % 2 == 0)
            {
                numB /= 2;
            }
            else
            {
                break;
            }
            count++;
        }

        return numA == numB ? count : -1;
    }

    static void PrintResult(int result)
    {
        SW.WriteLine(result);
    }
}