public class Program
{
    static void Main(string[] args)
    {
        string input;

        while (true)
        {
            input = Console.ReadLine();
            if (input == null)
            {
                break;
            }
            else
            {
                Console.WriteLine(input);
            }
        }
    }
}