public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size;
        int from = 1;
        int sub = 2;
        int to = 3;

        size = int.Parse(SR.ReadLine());

        PrintHanoiCount(size);
        PrintHanoi(size, from, sub, to);

        SR.Close();
        SW.Close();
    }

    static void PrintHanoiCount(int size)
    {
        SW.WriteLine(Math.Pow(2, size) - 1);
    }

    static void PrintHanoi(int size, int from, int sub, int to)
    {
        if (size == 1)
        {
            SW.WriteLine($"{from} {to}");
            return;
        }

        PrintHanoi(size - 1, from, to, sub);
        SW.WriteLine($"{from} {to}");
        PrintHanoi(size - 1, sub, from, to);
    }
}