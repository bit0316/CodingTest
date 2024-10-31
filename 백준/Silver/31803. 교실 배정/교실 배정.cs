public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        long result;

        size = int.Parse(SR.ReadLine());
        result = GetResult(size);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static long GetResult(int size)
    {
        long count = 1;

        for (int i = 1; i <= size; i += 2)
        {
            count *= i;
        }

        return count;
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}