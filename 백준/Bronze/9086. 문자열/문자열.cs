public class Program
{
    static void Main(string[] args)
    {
        int size;
        string input;

        size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            input = Console.ReadLine();
            Console.WriteLine($"{input[0]}{input[input.Length - 1]}");
        }
    }
}