public class Program
{
    static void Main(string[] args)
    {
        string input;
        int index;

        input = Console.ReadLine();
        index = int.Parse(Console.ReadLine());

        Console.WriteLine(input[index - 1]);
    }
}