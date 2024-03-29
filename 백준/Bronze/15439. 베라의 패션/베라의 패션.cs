public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int count;

        size = int.Parse(SR.ReadLine());
        count = GetCaseCount(size);
        PrintResult(count);

        SR.Close();
        SW.Close();
    }

    static int GetCaseCount(int size)
    {
        return size * (size - 1);
    }

    static void PrintResult(int value)
    {
        SW.WriteLine(value);
    }
}