public class Program
{
    static void Main(string[] args)
    {
        int height = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());

        Console.WriteLine(Math.Min(height, width) * 100 / 2);
    }
}