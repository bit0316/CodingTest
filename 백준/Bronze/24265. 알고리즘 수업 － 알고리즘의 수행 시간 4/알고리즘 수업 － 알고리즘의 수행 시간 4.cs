public class Program
{
    static void Main(string[] args)
    {
        long num;

        num = long.Parse(Console.ReadLine());

        Console.WriteLine(num * (num - 1) / 2);
        Console.WriteLine(2);
    }
}