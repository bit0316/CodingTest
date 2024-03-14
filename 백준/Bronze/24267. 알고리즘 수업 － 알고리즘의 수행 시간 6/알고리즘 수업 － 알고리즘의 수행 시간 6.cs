public class Program
{
    static void Main(string[] args)
    {
        long num;

        num = long.Parse(Console.ReadLine());

        Console.WriteLine(num * (num - 1) * (num - 2) / 6);
        Console.WriteLine(3);
    }
}