public class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        Console.WriteLine(count % 7 == 1 || count % 7 == 3 ? "CY" : "SK");
    }
}