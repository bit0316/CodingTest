public class Program
{
    static void Main(string[] args)
    {
        int num;

        num = int.Parse(Console.ReadLine());

        PrintPrimeFactorization(num);
    }

    static void PrintPrimeFactorization(int num)
    {
        int primeFactor;

        while (num > 1)
        {
            primeFactor = GetPrimeFactor(num);
            Console.WriteLine(primeFactor);
            num /= primeFactor;
        }
    }

    static int GetPrimeFactor(int num)
    {
        for (int i = 2; i < num; ++i)
        {
            if (num % i == 0)
            {
                return i;
            }
        }
        return num;
    }
}