public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size = 1000000;
        int num;
        bool[] isPrime;
        string[] input;

        isPrime = new bool[size + 1];
        SetArray(isPrime, size);

        num = int.Parse(SR.ReadLine());
        PrintResult(isPrime, num);

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

    static int GetGoldbach(bool[] isPrime, int num)
    {
        int count = 0;

        for (int i = 2; i <= num / 2; ++i)
        {
            if (isPrime[i] && isPrime[num - i])
            {
                count++;
            }
        }

        return count;
    }

    static void PrintResult(bool[] isPrime, int size)
    {
        int num;

        for (int i = 0; i < size; ++i)
        {
            num = int.Parse(SR.ReadLine());
            SW.WriteLine(GetGoldbach(isPrime, num));
        }

        SW.Flush();
    }
}