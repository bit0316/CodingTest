public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int num;
        long result;

        num = int.Parse(SR.ReadLine());

        result = GetFactorial(num);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static long GetFactorial(int num)
    {
        long result = 1;

        for (int i = 2; i <= num; ++i)
        {
            result *= i;
        }

        return result;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}