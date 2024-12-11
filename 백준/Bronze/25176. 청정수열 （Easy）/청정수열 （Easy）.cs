public class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int result = 1;

        for (int i = 2; i <= num; ++i)
        {
            result *= i;
        }

        Console.WriteLine(result);
    }
}