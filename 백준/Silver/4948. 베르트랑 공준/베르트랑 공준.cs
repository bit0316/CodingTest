public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size = 123456 * 2 + 1;
        bool[] isPrime;
        string[] input;

        isPrime = new bool[size + 1];
        SetArray(isPrime, size);
        PrintResult(isPrime);

        SR.Close();
        SW.Close();
    }

    static void SetArray(bool[] isPrime, int size)
    {
        for (int i = 2; i <= size; ++i)
        {
            isPrime[i] = true;
        }

        SetPrime(isPrime, size);
    }

    static void SetPrime(bool[] isPrime, int num)
    {
        for (int i = 2; i * i <= num; ++i)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j < num; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }
    }

    static int GetCount(bool[] isPrime, int min, int max)
    {
        int count = 0;

        for (int i = min + 1; i <= max; ++i)
        {
            if (isPrime[i])
            {
                count++;
            }
        }

        return count;
    }

    static void PrintResult(bool[] isPrime)
    {
        int num;

        while (true)
        {
            num = int.Parse(SR.ReadLine());
            if (num == 0)
            {
                break;
            }
            SW.WriteLine(GetCount(isPrime, num, num * 2));
        }

        SW.Flush();
    }
}