public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int MOD = 1000000007;

    static void Main(string[] args)
    {
        int size;
        long result;
        
        size = int.Parse(SR.ReadLine());
        result = GetResult(size);
        PrintResult(result);

        SR.Close();
        SW.Close();
    }

    static long GetResult(int size)
    {
        long numN, numS;
        long result = 0;
        long[] input;

        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), long.Parse);
            numN = input[0];
            numS = input[1];

            result += numS * Mod(numN, MOD - 2) % MOD;
            result %= MOD;
        }

        return result;
    }

    static long Mod(long numN, int numS)
    {
        if (numS == 1)
        {
            return numN % MOD;
        }

        if (numS % 2 == 1)
        {
            return numN * Mod(numN, numS - 1) % MOD;
        }

        return Mod(numN * numN % MOD, numS / 2);
    }

    static void PrintResult(long result)
    {
        SW.WriteLine(result);
    }
}