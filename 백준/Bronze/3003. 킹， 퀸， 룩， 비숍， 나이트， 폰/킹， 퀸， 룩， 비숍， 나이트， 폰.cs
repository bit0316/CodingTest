public class Program
{
    static void Main(string[] args)
    {
        int[] pieces = { 1, 1, 2, 2, 2, 8 };
        string[] input;

        input = Console.ReadLine().Split();

        for (int i = 0; i < pieces.Length; ++i)
        {
            Console.Write($"{pieces[i] - int.Parse(input[i])} ");
        }
    }
}