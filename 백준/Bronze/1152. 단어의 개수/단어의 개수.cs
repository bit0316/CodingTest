public class Program
{
    static void Main(string[] args)
    {
        string[] input;

        input = Console.ReadLine().Trim().Split();

        if (input[0] == "")
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(input.Length);
        }
    }
}