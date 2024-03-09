public class Program
{
    static void Main(string[] args)
    {
        int[] sec = { 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 10, 10, 10, 10 };
        int sum = 0;
        string input;

        input = Console.ReadLine();

        for (int i = 0; i < input.Length; ++i)
        {
            sum += sec[input[i] - 'A'];
        }

        Console.WriteLine(sum);
    }
}