public class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        Console.WriteLine(count % 7 == 0 || count % 7 == 2 ? "CY" : "SK");
    }
}