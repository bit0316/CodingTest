public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size = 1000000;
        int min;
        int max;
        bool[] isPrime;
        string[] input;

        isPrime = new bool[size + 1];
        SetArray(isPrime, size);

        input = SR.ReadLine().Split();
        min = int.Parse(input[0]);
        max = int.Parse(input[1]);
        PrintResult(isPrime, min, max);

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

    static void PrintResult(bool[] isPrime, int min, int max)
    {
        for (int i = min; i <= max; ++i)
        {
            if (isPrime[i])
            {
                SW.WriteLine(i);
            }
        }

        SW.Flush();
    }
}