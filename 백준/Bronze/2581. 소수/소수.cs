public class Program
{
    static void Main(string[] args)
    {
        int numA;
        int numB;

        numA = int.Parse(Console.ReadLine());
        numB = int.Parse(Console.ReadLine());

        PrintResult(numA, numB);
    }

    static void PrintResult(int numA, int numB)
    {
        int sum = 0;
        int min = 0;

        for (int i = numB; i >= numA; --i)
        {
            if (IsPrimeNum(i))
            {
                sum += i;
                min = i;
            }
        }

        if (sum != 0)
        {
            Console.WriteLine(sum);
            Console.WriteLine(min);
        }
        else
        {
            Console.WriteLine(-1);
        }
    }

    static bool IsPrimeNum(int num)
    {
        if (num == 1)
        {
            return false;
        }

        for (int i = 2; i < num; ++i)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}