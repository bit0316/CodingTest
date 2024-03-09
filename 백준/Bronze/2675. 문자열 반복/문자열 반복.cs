public class Program
{
    static void Main(string[] args)
    {
        int size;
        int count;
        string text;
        string[] input;

        size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size; ++i)
        {
            input = Console.ReadLine().Split();
            count = int.Parse(input[0]);
            text = input[1];
            for (int j = 0; j < count * text.Length; ++j)
            {
                Console.Write(text[j / count]);
            }
            Console.WriteLine();
        }
    }
}