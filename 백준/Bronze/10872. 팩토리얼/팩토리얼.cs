public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int count;

        size = int.Parse(SR.ReadLine());
        count = GetFactorial(size);
        PrintResult(count);

        SR.Close();
        SW.Close();
    }

    static int GetFactorial(int size)
    {
        int factorial = 1;

        for (int i = 1; i <= size; ++i)
        {
            factorial *= i;
        }

        return factorial;
    }

    static void PrintResult(int value)
    {
        SW.WriteLine(value);
    }
}