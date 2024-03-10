public class Program
{
    static void Main(string[] args)
    {
        string input;

        input = Console.ReadLine();

        for (int i = 0; i < input.Length; ++i)
        {
            if (input[i] != input[input.Length - i - 1])
            {
                Console.WriteLine(0);
                return;
            }
        }
        Console.WriteLine(1);
    }
}