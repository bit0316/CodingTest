public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MOD = 1000000;

    static Dictionary<long, long> dict = new Dictionary<long, long>();

    static void Main(string[] args)
    {
        long num;
        long result;

        num = long.Parse(SR.ReadLine());

        dict.Add(0, 0);
        dict.Add(1, 1);
        result = Fibo(num);

        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static long Fibo(long num)
    {
        long fiboA;
        long fiboB;

        if (!dict.ContainsKey(num))
        {
            if (num % 2 == 0)
            {
                fiboA = Fibo(num / 2);
                fiboB = Fibo(num / 2 - 1);
                dict.Add(num, (2 * fiboB + fiboA) * fiboA % MOD);
            }
            else
            {
                fiboA = Fibo(num / 2);
                fiboB = Fibo(num / 2 + 1);
                dict.Add(num, (fiboA * fiboA + fiboB * fiboB) % MOD);
            }
        }

        return dict[num];
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}