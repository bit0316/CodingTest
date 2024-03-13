public class Program
{
    static void Main(string[] args)
    {
        int size;
        int result = 0;
        string[] input;

        size = int.Parse(Console.ReadLine());
        input = Console.ReadLine().Split();

        for (int i = 0; i < size; ++i)
        {
            result += CheckPrimeNum(int.Parse(input[i]));
        }

        Console.WriteLine(result);
    }

    static int CheckPrimeNum(int num)
    {
        if (num == 1)
        {
            return 0;
        }

        for (int i = 2; i < num; ++i)
        {
            if (num % i == 0)
            {
                return 0;
            }
        }

        return 1;
    }
}