public class Program
{
    static void Main(string[] args)
    {
        int num;
        int result = 0;

        num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; ++i)
        {
            result += i;
        }

        Console.WriteLine(result);
    }
}