public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;

        size = int.Parse(SR.ReadLine());
        PrintResult(size);

        SR.Close();
        SW.Close();
    }

    static void PrintResult(int size)
    {
        for (int i = 1; i <= size; ++i)
        {
            SW.WriteLine(i);
        }

        SW.Flush();
    }
}