public class Program
{
    static void Main(string[] args)
    {
        int size;
        int sum = 0;
        string input;

        size = int.Parse(Console.ReadLine());
        input = Console.ReadLine();

        for (int i = 0; i < size; ++i)
        {
            sum += int.Parse(input[i].ToString());
        }

        Console.WriteLine(sum);
    }
}