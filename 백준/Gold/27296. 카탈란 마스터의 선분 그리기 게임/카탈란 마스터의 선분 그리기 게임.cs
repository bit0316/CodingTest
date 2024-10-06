public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        long num;

        size = int.Parse(SR.ReadLine());
        for (int i = 0; i < size; ++i)
        {
            num = long.Parse(SR.ReadLine());
            PrintResult(num);
        }

        SR.Close();
        SW.Close();
    }

    static void PrintResult(long num)
    {
        SW.WriteLine(num <= 1 ? "1 0" : "0 1");
    }
}