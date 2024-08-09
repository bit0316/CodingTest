public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MAX_PRIME = 1000;

    static bool[] isPrime;

    static void Main(string[] args)
    {
        int ytMin, ytMax;
        int yjMin, yjMax;
        int result;
        int[] input;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        ytMin = input[0];
        ytMax = input[1];

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        yjMin = input[0];
        yjMax = input[1];

        SetPrime();
        result = GetResult(ytMin, ytMax, yjMin, yjMax);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static void SetPrime()
    {
        isPrime = new bool[MAX_PRIME + 1];
        for (int i = 2; i <= MAX_PRIME; ++i)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i * i <= MAX_PRIME; ++i)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= MAX_PRIME; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }
    }

    static int GetResult(int ytMin, int ytMax, int yjMin, int yjMax)
    {
        int ytCount = 0;
        int yjCount = 0;
        int commonCount = 0;

        for (int i = ytMin; i <= ytMax; ++i)
        {
            if (isPrime[i])
            {
                ytCount++;
            }
        }

        for (int i = yjMin; i <= yjMax; ++i)
        {
            if (isPrime[i])
            {
                yjCount++;
            }
        }

        if (ytCount == yjCount)
        {
            if (ytMin > yjMin)
            {
                (yjMin, ytMax) = (ytMin, yjMax);
            }

            for (int i = yjMin; i <= ytMax; ++i)
            {
                if (isPrime[i])
                {
                    commonCount++;
                }
            }

            return commonCount % 2 == 0 ? -1 : 1;
        }
        else
        {
            return ytCount - yjCount;
        }
    }

    static void PrintResult(int result)
    {
        if (result < 0)
        {
            SW.WriteLine("yj");
        }
        else
        {
            SW.WriteLine("yt");
        }
    }
}