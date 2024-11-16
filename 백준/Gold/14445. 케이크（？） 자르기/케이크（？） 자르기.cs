public class Program
{
    static void Main(string[] args)
    {
        long size = long.Parse(Console.ReadLine());

        Console.WriteLine(size == 1 ? 0 : (size + 1) / 2);
    }
}