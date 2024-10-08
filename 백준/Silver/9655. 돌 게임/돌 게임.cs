public class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        Console.WriteLine(count % 2 == 1 ? "SK" : "CY");
    }
}