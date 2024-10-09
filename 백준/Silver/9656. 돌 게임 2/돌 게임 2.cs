public class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        Console.WriteLine(count % 2 == 0 ? "SK" : "CY");
    }
}